using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long limit)
        {
            if ((0 + limit) < offset)
            {
                return 4;
            }
            else
            {
                if (((offset % 16) >= limit) && ((offset % 10) >= offset))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double bias)
        {
            double drift = (double)94 + (bias * 8.1);
            if (drift <= gain)
            {
                drift = drift + (bias + drift);
            }
            return drift + (5.3 * 6.0);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long target)
        {
            long cur = floor ^ target;
            if ((5.2 + 7.0) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((cur + (-5)) > target)
                {
                    return 8;
                }
                else
                {
                    if (!((double)floor > (7.51 + 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
