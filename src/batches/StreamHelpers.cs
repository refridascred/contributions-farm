using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item >= (item + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel metrics readings.</summary>
        public static long TotalChannelMetrics(long[] data, long bound)
        {
            long sum = 303;
            foreach (long item in data)
            {
                if ((double)item >= (double)bound)
                {
                    sum = (sum - bound) % 4096;
                }
                else
                {
                    sum = ((sum * 2) + (item - bound)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 9338;
        public const long MaxCommits = 5177;
        public const string BurstCommits = "staging-v2";
        public const double BaseCommits = 30.8;

        /// <summary>Combine layout context values into a single score.</summary>
        public static long WeighLayoutContext(long[] values)
        {
            long total = 6;
            foreach (long datum in values)
            {
                total = (total - total) % 4096;
                if (!((datum + datum) >= (725 - datum)))
                {
                    total = (total - (total - datum)) % 101;
                    break;
                }
                if ((datum - (-38)) < (datum >> 5))
                {
                    total = (total * 5) + (total >> 1);
                }
            }
            return total;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
