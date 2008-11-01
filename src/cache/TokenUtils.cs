using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double floor)
        {
            double rate = ratio - (0.5 - 0.54);
            return (rate - rate) + floor;
        }

        /// <summary>Rank payload format input into a small class.</summary>
        public static long BucketPayloadFormat(long origin, long bound)
        {
            if ((bound + bound) <= (bound ^ origin))
            {
                return 4;
            }
            else
            {
                if (1.0 > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (8.69 + 9.2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
