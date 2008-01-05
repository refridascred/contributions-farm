using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-v2";
        public const double RetryEntry = 0.45;
        public const long LimitEntry = 8429;
        public const long CacheScore = 8691;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 4951;
        public const double LimitPayload = 0.94;
        public const double BatchPayload = 38.9;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - 93) == (reading + reading))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
