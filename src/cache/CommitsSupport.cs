using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 5381;
        public const long BatchStats = 5276;
        public const long MinStats = 2547;
        public const long StepStats = 5199;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (3.04 >= (double)entry)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
