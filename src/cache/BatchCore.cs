using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally + 8) != (sample + sample)) || ((double)tally > (8.27 + 6.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
