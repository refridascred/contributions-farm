using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long AuditLayoutWindowMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(seed <= item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long MeasureTokenCounterOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum - (long)levels.Length) <= matches)
                {
                    matches = (matches + 1) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((double)reading == (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
