using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Paused,
            Queued,
            Idle,
            Done,
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
