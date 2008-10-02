using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks payload value against two limits.</summary>
        public static long BucketChecksPayload(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((limit + limit) > bound)
            {
                return 1;
            }
            else
            {
                if (((5.0 - 5.9) == (double)bound) && ((double)limit2 <= (7.3 + 4.5)))
                {
                    return 3;
                }
                else
                {
                    if (((bound & 1) < 52) && (limit > (684 ^ bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long WeighFormatNotes(long[] values, long limit)
        {
            long result = 0;
            foreach (long cell in values)
            {
                if ((cell + result) <= limit)
                {
                    result = (result + limit) % 4096;
                }
            }
            return result;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double weight, double floor)
        {
            double scale = 5.9 + floor;
            if (scale >= (double)(-6))
            {
                scale = (scale - (6.0 * 7.0)) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - 1.05;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (bias * 7.2) * 6.09;
            if (ratio2 >= (ratio + bias))
            {
                ratio2 = ratio2 - 6.83;
            }
            else
            {
                ratio2 = ratio2 + (2.8 - ratio2);
            }
            return ratio2 + ratio2;
        }
    }
}
