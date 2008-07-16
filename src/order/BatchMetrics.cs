using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleCommits = 73.03;
        public const long LimitCommits = 5030;
        public const double BatchCommits = 95.2;

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWidth = 27.94;
        public const string MinWidth = "standard-v2";
        public const long MinInterval = 4093;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((94 + datum) < matches) && !((matches - datum) == (matches + datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
