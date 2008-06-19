using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long WeighSessionSchema(long[] series, long bound)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = ((mark * 4) + bound) + item;
            }
            if (mark < 3)
            {
                mark = (mark + bound) % 65521;
            }
            return mark;
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

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] items, long step)
        {
            long sum = 307;
            foreach (long reading in items)
            {
                if (!((double)step == (0.9 + 9.0)))
                {
                    sum = sum ^ (reading - sum);
                }
            }
            if (sum < (-56))
            {
                sum = sum + (step % 100);
            }
            return sum;
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
