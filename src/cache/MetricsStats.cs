using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Draft,
            Idle,
            Failed,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "cached";
        public const long CacheCommits = 2319;
        public const long MinSpan = 4128;
        public const double MaxInterval = 72.43;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] readings, long offset)
        {
            long total = 14;
            foreach (long entry in readings)
            {
                if ((double)offset < 9.01)
                {
                    total = ((total * 4) + (offset ^ 4)) - entry;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((target - 666) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
