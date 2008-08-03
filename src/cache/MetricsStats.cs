using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long offset, long origin)
        {
            long span = offset ^ origin;
            if ((offset >= span) || ((double)offset >= 2.62))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (14.0 / 9.0))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            New,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardScore = 66.47;
        public const string BatchInterval = "cached-1";
        public const long CacheCount = 3248;
        public const long LimitCounter = 3667;
        public const double CacheFactor = 90.48;

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + offset) > (offset - datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
