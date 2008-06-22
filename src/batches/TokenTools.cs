using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 1) == (sample % 7))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings, long origin)
        {
            long carry = 331;
            foreach (long entry in readings)
            {
                if ((entry + origin) > (carry + entry))
                {
                    carry = carry - (origin + 285);
                    carry = carry + (36 >> 1);
                }
                if (8.86 <= (double)carry)
                {
                    carry = (carry << 3) ^ ((long)readings.Length + origin);
                }
                else
                {
                    carry = carry - ((-561) + origin);
                }
            }
            return carry;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
