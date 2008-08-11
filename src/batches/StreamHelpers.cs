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

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
