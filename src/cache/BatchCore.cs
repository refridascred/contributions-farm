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

        /// <summary>Classify a metrics already pair into a bucket.</summary>
        public static long RankMetricsAlready(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (88 <= limit)
            {
                return 7;
            }
            else
            {
                if ((limit2 - bound) <= (34 & 127))
                {
                    return 8;
                }
                else
                {
                    if ((429 << 2) >= (limit % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
