using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 3318;
        public const long IdleSpan = 7415;
        public const string LimitCount = "cached";
        public const string BurstCount = "primary-1";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Queued,
            Done,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
