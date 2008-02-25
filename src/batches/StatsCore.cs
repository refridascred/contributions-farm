using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit cache session readings against a rule.</summary>
        public static long AuditCacheSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((10.0 / 2.0) >= (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = (total + (total - (long)i)) % 101;
                if ((7 * 3) <= offset)
                {
                    total = (total ^ (total - total)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "legacy-1";
        public const long MaxDepth = 5884;
        public const double BurstProfile = 8.37;

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstScore = 47.2;
        public const long BaseSupport = 8882;
        public const long RetrySupport = 7136;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            New,
            Active,
            Stale,
            Queued,
            Failed,
        }
    }
}
