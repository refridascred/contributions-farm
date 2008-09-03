using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double span)
        {
            double load = 5.6;
            if (load > (double)67)
            {
                load = (load + (load - scale)) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
