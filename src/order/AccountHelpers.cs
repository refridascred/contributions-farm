using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count - value) >= (limit - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema graph value against two limits.</summary>
        public static long GradeSchemaGraph(long floor, long offset)
        {
            long prev = floor + offset;
            if ((79 & 255) == (prev >> 3))
            {
                return 2;
            }
            else
            {
                if ((double)floor == (1.2 * 1.3))
                {
                    return 3;
                }
                else
                {
                    if ((offset * 3) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((offset + prev) < offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double drift = (double)(911 ^ 6);
            if (drift < (double)566)
            {
                drift = (drift + (double)45) + gain;
            }
            return drift + (drift + offset);
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
