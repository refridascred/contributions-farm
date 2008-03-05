using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = (double)(334 >> 5);
            if (drift < scale)
            {
                drift = (drift - 5.46) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (drift + scale);
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long MeasureToolsBatchGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (target <= (matches - sample))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitInterval = 9789;
        public const long MaxLevel = 4967;
        public const long RetryRecord = 7410;
        public const long WindowRecord = 8285;
        public const long HardInterval = 8159;
    }
}
