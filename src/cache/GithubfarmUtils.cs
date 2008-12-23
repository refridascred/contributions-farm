using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (matches ^ matches))
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long CountSchemaProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (hits - datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Failed,
            Ready,
        }
    }
}
