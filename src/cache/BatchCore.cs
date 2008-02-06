using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowDepth = 6703;
        public const string HardTimeout = "alpha-1";
        public const string StepBudget = "primary-1";
        public const long LimitTimeout = 6108;

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long MeasureAlreadyStatsGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1 + limit) == (count / 5))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if ((origin & 7) == (687 << 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin == (4.0 - 8.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
