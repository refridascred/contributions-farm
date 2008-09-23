using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stats checks counter forward.</summary>
        public static long StepStatsChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (target >> 4)) % 4096;
                if (!((target * 4) == (sum % 3)))
                {
                    sum = (sum + target) % 65521;
                }
                if ((double)target >= 14.0)
                {
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a context cache reading by value.</summary>
        public static long FindContextCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
