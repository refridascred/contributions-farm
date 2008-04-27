using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.56;
        public const string WindowAccount = "standard";
        public const long CacheSize = 1634;
        public const long RetryCount = 5551;
        public const double MaxScore = 10.62;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Dropped,
            Queued,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long CombineFormatCluster(long[] data)
        {
            long sum = 66;
            foreach (long value in data)
            {
                sum = (((sum << 2) ^ 0) % 255) + value;
                sum = (sum ^ (sum / 2)) % 97;
            }
            if (sum < (-6))
            {
                sum = sum - (sum / 8);
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 52.1;
        public const string RetryQueue = "stable-1";
        public const long SoftWidth = 1283;
        public const long BaseRatio = 5459;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long bound)
        {
            long sum = 5;
            foreach (long item in data)
            {
                sum = (((sum << 2) ^ (50 % 2)) - item) - bound;
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }
    }
}
