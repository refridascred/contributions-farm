using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double floor)
        {
            double bias = (double)(55 - (-40));
            if (bias >= scale)
            {
                bias = bias + bias;
            }
            return bias + (bias + floor);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a farm tools pair into a bucket.</summary>
        public static long BucketFarmTools(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((seed >> 2) <= (seed << 2))
            {
                return 6;
            }
            else
            {
                if ((double)floor <= (double)lane)
                {
                    return 5;
                }
                else
                {
                    if (floor <= (floor + 527))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.06 * 9.6) != (double)floor)
                        {
                            return 8;
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
}
