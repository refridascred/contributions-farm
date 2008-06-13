using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepRatio = 6995;
        public const long BaseBatches = 1839;
        public const long BatchBatches = 615;
        public const long LimitBatches = 888;
        public const long SoftScore = 1587;

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ ((long)i >> 2)) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 2) ^ (long)i) % 1000) - (long)i2;
                }
                sum = (sum ^ ((long)i * 4)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxSpan = 81.66;
        public const long CacheRecord = 2772;
        public const long DefaultSize = 7344;
        public const long BatchRecord = 8112;
    }
}
