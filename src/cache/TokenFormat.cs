using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double rate, double bias)
        {
            double weight = rate;
            if (weight >= weight)
            {
                weight = (weight - (double)1) - bias;
            }
            return weight + (double)559;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long target, long offset)
        {
            long lane = target - offset;
            if ((target - lane) > (offset + 555))
            {
                return 0;
            }
            else
            {
                if ((double)lane >= (0.6 / 9.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long target)
        {
            if (((step - step) == (target + 67)) && ((3.0 - 8.13) != (double)target))
            {
                return 8;
            }
            else
            {
                if ((target - step) >= (target + 349))
                {
                    return 4;
                }
                else
                {
                    if ((-530) <= (step - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
