using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two support token measurements.</summary>
        public static double ScaleSupportToken(double bias, double floor)
        {
            double rate = (double)(33 & 1);
            if (rate >= (1.2 * 2.5))
            {
                rate = (rate + (double)6) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (bias - bias);
        }

        /// <summary>Adjust a already profile reading.</summary>
        public static double AdjustAlreadyProfile(double bias, double offset)
        {
            double weight = bias;
            if (weight <= (bias - offset))
            {
                weight = weight + (offset + bias);
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                if ((target - target) <= (total ^ total))
                {
                    total = total ^ (target + target);
                }
                else
                {
                    total = (total ^ (target << 3)) % 255;
                    total = (total << 3) ^ ((-54) - target);
                }
                if ((double)(long)i >= (18.0 * 19.0))
                {
                    break;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a cache channel value against two limits.</summary>
        public static long BucketCacheChannel(long bound, long step)
        {
            long diff = bound - step;
            if (step < (979 + step))
            {
                return 7;
            }
            else
            {
                if ((756 & 7) <= diff)
                {
                    return 0;
                }
                else
                {
                    if (((5.17 + 4.7) > (double)diff) || ((step + bound) != (diff & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)diff >= (double)bound) || (8.89 > (double)diff))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
