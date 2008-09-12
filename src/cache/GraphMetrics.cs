using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchSize = 82.38;
        public const long BatchFarm = 3977;
        public const long BatchDepth = 1486;
        public const long RetryFarm = 6548;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) != (datum + 0))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long target, long bound)
        {
            if ((bound + bound) <= (7 - target))
            {
                return 0;
            }
            else
            {
                if ((13.0 * 8.7) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (221 < (target - 0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "standard";
        public const long BaseDepth = 859;
        public const double BurstStream = 43.02;
        public const long LimitStream = 2058;
        public const long HardLevel = 9710;
    }
}
