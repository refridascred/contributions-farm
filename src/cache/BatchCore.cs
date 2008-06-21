using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a session support figure with a bias.</summary>
        public static double SmoothSessionSupport(double scale, double bias)
        {
            double ratio = (double)(-233) * 1.7;
            if (ratio < bias)
            {
                ratio = ratio - (scale * 5.0);
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias / 2.0)) - (double)(long)i;
            }
            return ratio + (double)525;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftTimeout = 4451;
        public const long LimitSchema = 7128;
        public const long MinSchema = 9194;
        public const long IdleInterval = 302;
        public const long CacheSchema = 5626;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Draft,
            Done,
            Pending,
        }
    }
}
