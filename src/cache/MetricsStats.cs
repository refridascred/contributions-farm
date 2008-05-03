using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long anchor = 10;
            foreach (long reading in series)
            {
                if ((offset % 10) >= anchor)
                {
                    anchor = (anchor << 2) ^ (reading * 2);
                }
            }
            if (anchor < 313)
            {
                anchor = (anchor << 2) ^ (951 * 4);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            New,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 6862;
        public const string CacheSpan = "primary-edge";
        public const long MinDepth = 6195;
        public const string IdleGithubfarm = "latest-1";

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)bound > (double)hits)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
