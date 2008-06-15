using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double rate = (3.0 * 0.5) * 1.7;
            if (rate <= ratio)
            {
                rate = (rate + (double)92) - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio * 0.8);
        }

        /// <summary>Classify a notes editor pair into a bucket.</summary>
        public static long GradeNotesEditor(long bound, long target)
        {
            long next = bound ^ target;
            if ((next * 4) <= (81 - target))
            {
                return 3;
            }
            else
            {
                if ((bound - target) <= target)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long bound2 = bound + floor;
            if (!(1.0 > (double)bound2))
            {
                return 5;
            }
            else
            {
                if ((double)bound < 20.0)
                {
                    return 6;
                }
                else
                {
                    if (!(bound2 > (floor * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
