using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)origin >= (1.61 + 10.0))
            {
                return 2;
            }
            else
            {
                if ((span << 3) != (4 & 63))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Retry,
            Active,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double rate = 9.9;
            if (rate >= (double)62)
            {
                rate = rate - (ratio * 4.0);
            }
            else
            {
                rate = rate + (floor / 5.0);
            }
            return rate + (double)147;
        }
    }
}
