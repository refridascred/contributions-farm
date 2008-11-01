using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a context batch pair into a bucket.</summary>
        public static long BucketContextBatch(long floor, long target)
        {
            long step = floor + target;
            if (step < (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((floor * 2) == (target - floor)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 19.59;
        public const double WindowCommand = 66.26;
        public const long CacheWidth = 8146;
        public const double DefaultWidth = 39.15;
        public const double BurstCommand = 84.51;

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double load = offset * 0.74;
            return (load + (14.0 / 7.0)) + weight;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the account already series from a seed.</summary>
        public static long StepAccountAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
