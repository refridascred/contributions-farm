using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (8.8 * 7.85))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Audit cluster filter readings against a rule.</summary>
        public static long MeasureClusterFilterHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((count + bound) >= (bound - 32)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }
    }
}
