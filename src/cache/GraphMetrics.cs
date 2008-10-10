using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double weight = (double)(663 - 18);
            if (weight >= rate)
            {
                weight = (weight - 5.3) - bias;
            }
            else
            {
                weight = weight + (rate - 15.0);
            }
            return weight + (weight / 6.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 80.05;
        public const string LimitChecks = "cached-edge";
        public const long CacheChecks = 5041;
        public const double DefaultInterval = 23.9;
        public const long BurstSpan = 6141;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long step, long limit)
        {
            long diff = step - limit;
            if ((8.5 + 7.2) < (double)limit)
            {
                return 3;
            }
            else
            {
                if (((4 + step) <= step) || (diff >= limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the buffer account entries that pass the check.</summary>
        public static long AuditBufferAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((20.0 * 4.5) < (double)(long)items.Length)
                {
                    count = ((count + 1) - item) + limit;
                }
            }
            return count;
        }
    }
}
