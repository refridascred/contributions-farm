using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheFactor = "legacy-v2";
        public const double StepQueue = 1.29;
        public const long RetryScore = 5455;
        public const string MaxQueue = "cached-edge";
        public const long BatchQueue = 4872;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - 337) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series, long offset)
        {
            long mark = 64;
            foreach (long reading in series)
            {
                mark = (mark + (offset % 12)) + reading;
            }
            if (mark < 8)
            {
                mark = (mark ^ ((-2) << 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((datum & 15) > (datum >> 1)))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Pending,
            Failed,
            Dropped,
            Idle,
            Stale,
        }
    }
}
