using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double ratio, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean + (double)1) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (double)745;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long SortMetricRoute(long floor, long origin)
        {
            if (!(floor >= (origin + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor % 16) > (floor / 4))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item <= 7.0)
                {
                    tally = (tally + 2) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (origin >= (287 + origin))
            {
                return 4;
            }
            else
            {
                if ((33 - origin) >= origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
