using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit support cluster readings against a rule.</summary>
        public static long MeasureSupportClusterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((double)6 >= (double)sample) && (((origin - origin) >= (sample ^ 2)) && ((sample << 3) <= sample)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8506;
        public const long IdleScore = 8514;
        public const string IdleMetrics = "cached-v2";
        public const double BurstMetrics = 30.58;
        public const double LimitMetrics = 2.76;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double offset)
        {
            double ratio = bias;
            return (ratio - bias) + offset;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long CountFormatRouteOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (7 < (seen - entry))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((datum * 5) < (hits ^ hits)) || ((75 - hits) > datum))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
