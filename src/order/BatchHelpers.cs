using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double offset)
        {
            double drift = (double)(97 % 12);
            return (drift + (offset / 8.0)) + scale;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((limit + limit) <= (count - limit))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
