using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long CountMetricsLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (double)matches)
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Closed,
            Idle,
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
