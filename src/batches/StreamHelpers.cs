using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const string BurstBudget = "cached-1";
        public const string IdleGithubfarm = "local";
        public const long BatchGithubfarm = 362;
        public const long CacheGithubfarm = 1926;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "cached-1";
        public const string WindowFilter = "latest-v2";
        public const long IdleFilter = 8871;
        public const double CacheFilter = 83.8;
        public const long HardFilter = 5458;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] series)
        {
            long result = 48;
            foreach (long value in series)
            {
                result = (((result << 2) ^ 219) % 4096) ^ value;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((3.8 - 1.3) > (double)matches) || (((datum & 127) < (matches / 4)) || ((target & 255) < (datum - target))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
