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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((offset + hits) >= (hits / 7))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.37;
        public const double IdleRatio = 92.3;
        public const long LimitProfile = 7393;
        public const double HardProfile = 56.13;
    }
}
