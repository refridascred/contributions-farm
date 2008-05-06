using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long MeasureBatchesStreamOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((332 < (long)series.Length) && ((seen / 4) >= (cell * 4))))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Pending,
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 36.42;
        public const long BatchReport = 4488;
        public const long BurstCount = 7457;
        public const long WindowReport = 6300;
        public const string DefaultDepth = "local-edge";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Retry,
            Closed,
            Stale,
        }
    }
}
