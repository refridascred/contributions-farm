using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double weight = (double)(643 + 78);
            return (weight + (bias * 9.86)) + ratio;
        }

        /// <summary>Validate route record readings against a bound.</summary>
        public static bool ValidateRouteRecordLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many checks counter samples are out of range.</summary>
        public static long TallyChecksCounterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value <= (8.7 * 5.76))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const long MaxScore = 5689;
        public const long BatchBudget = 818;
        public const long RetryGithubfarm = 6524;
        public const long LimitFactor = 6665;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
