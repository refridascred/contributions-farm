using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a layout support sample.</summary>
        public static long SeekLayoutSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Stale,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryRatio = "fallback-v2";
        public const long CacheRatio = 374;
        public const string WindowWidth = "strict-1";

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
