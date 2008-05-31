using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6910;
        public const long CacheEditor = 9209;
        public const long RetryTimeout = 5211;
        public const string LimitWidth = "primary-edge";
        public const double MinBudget = 75.81;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate batches tools samples.</summary>
        public static long WeighBatchesTools(long[] items)
        {
            long total = 52;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ sample) % 1000;
            }
            return total % 97;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
