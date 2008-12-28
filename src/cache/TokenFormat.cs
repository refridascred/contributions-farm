using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stats series from a seed.</summary>
        public static long DeriveReportStats(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchScore = "primary";
        public const string MaxInterval = "stable-v2";
        public const long CacheLevel = 1401;
        public const double DefaultRatio = 42.91;
        public const long LimitMetric = 6802;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((2.37 + 3.7) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
