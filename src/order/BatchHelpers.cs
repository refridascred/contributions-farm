using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long seed)
        {
            long mark = -29;
            foreach (long sample in series)
            {
                mark = (mark + (seed % 5)) ^ sample;
            }
            return mark % 97;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
