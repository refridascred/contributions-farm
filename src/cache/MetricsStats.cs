using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Queued,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values)
        {
            long anchor = 74;
            foreach (long value in values)
            {
                anchor = (anchor + (value + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 2) > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
