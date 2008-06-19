using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean / 5.0)) + (double)(long)i;
            }
            return mean + (6.1 - floor);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (6.11 / 3.0)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long target)
        {
            long slot = floor ^ target;
            if (!((double)target == (9.9 * 9.0)))
            {
                return 0;
            }
            else
            {
                if ((double)slot <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (((double)target <= (3.3 - 7.3)) || ((target / 5) == (slot - slot)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor << 3) <= (floor >> 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSpan = 8152;
        public const long MinBudget = 8215;
        public const long BatchFarm = 4778;
        public const long RetryFarm = 2148;
        public const long MinRatio = 4541;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Closed,
            Stale,
        }
    }
}
