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

        /// <summary>Check that every cache graph entry stays within the limit.</summary>
        public static bool CheckCacheGraphLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
