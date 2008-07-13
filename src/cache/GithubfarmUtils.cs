using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((total + 257) >= (origin - (long)i))
                {
                    total = ((total * 2) + (origin >> 2)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((4.0 - 9.33) == (double)seen))
                {
                    seen = ((seen + 1) + entry) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((8.3 - 20.0) != (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
