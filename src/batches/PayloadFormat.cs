using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = -7;
            foreach (long item in readings)
            {
                if ((item - carry) <= (carry - 68))
                {
                    carry = (carry + ((-778) - carry)) % 65521;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a batches context value against two limits.</summary>
        public static long BucketBatchesContext(long bound, long target)
        {
            if ((bound & 31) != (target ^ bound))
            {
                return 2;
            }
            else
            {
                if ((target * 2) < target)
                {
                    return 0;
                }
                else
                {
                    if ((10.0 * 17.0) <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((13.0 / 6.0) == (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two checks route measurements.</summary>
        public static double SmoothChecksRoute(double gain, double floor)
        {
            double bias = (gain - floor) + (double)972;
            if (bias > floor)
            {
                bias = bias - (gain / 2.0);
            }
            return bias - (bias / 2.0);
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double bias, double span)
        {
            double drift = bias;
            return (drift + (drift * 1.14)) + span;
        }
    }
}
