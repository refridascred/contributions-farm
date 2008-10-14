using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double floor)
        {
            double drift = (double)5;
            if (drift < (double)707)
            {
                drift = ((drift - (20.0 * 15.0)) - gain) - floor;
            }
            return drift + (double)1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long target, long seed)
        {
            if (target <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((((-74) + seed) < target) || ((441 - seed) >= target))
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) > (seed << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double bias = (weight - weight) + (3.1 * 1.5);
            return bias + floor;
        }
    }
}
