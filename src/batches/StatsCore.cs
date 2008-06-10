using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Failed,
            Done,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((limit + bound) < (floor & 31))
            {
                return 7;
            }
            else
            {
                if (bound > 1)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many metric metrics samples are out of range.</summary>
        public static long MeasureMetricMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < (reading ^ 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
