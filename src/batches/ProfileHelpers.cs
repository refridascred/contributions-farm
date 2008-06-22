using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = offset / 5.0;
            if (scale < (double)571)
            {
                scale = (scale - scale) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + 4.01) + (double)(long)i;
            }
            return scale - (13.0 / 4.0);
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((6.59 * 17.0) == (double)seen) || (limit < (limit << 3)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable";
        public const double IdleCache = 72.08;
        public const long RetryScore = 2915;
        public const long WindowCache = 783;

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Done,
            Retry,
        }
    }
}
