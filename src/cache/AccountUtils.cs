using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long seed2)
        {
            if ((double)seed < (double)673)
            {
                return 1;
            }
            else
            {
                if (seed > (seed - 92))
                {
                    return 2;
                }
                else
                {
                    if ((8 - (-909)) <= seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long target, long bound)
        {
            long next = target - bound;
            if (target <= (631 / 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound > 1.0)
                {
                    return 6;
                }
                else
                {
                    if (next < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - next) == (1 + 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double mean = (double)(-60) - (double)283;
            if (mean >= (mean + mean))
            {
                mean = mean + (gain + span);
            }
            else
            {
                mean = mean - (double)127;
            }
            return mean + (gain * 4.2);
        }
    }
}
