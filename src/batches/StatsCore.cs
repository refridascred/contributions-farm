using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "local-v2";
        public const long BurstCommand = 1270;
        public const long WindowDepth = 5948;
        public const long SoftCommand = 7439;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheDepth = 6844;
        public const long MaxCount = 2981;
        public const double RetryFarm = 2.95;
        public const long HardFarm = 5957;
        public const double IdleFarm = 11.36;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long TotalGraphMetric(long[] values, long limit)
        {
            long sum = 0;
            foreach (long reading in values)
            {
                if ((limit % 60) > (limit * 3))
                {
                    sum = ((sum - (sum % 8)) % 97) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
