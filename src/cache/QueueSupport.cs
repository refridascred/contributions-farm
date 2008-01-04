using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank farm window input into a small class.</summary>
        public static long BucketFarmWindow(long floor, long bound)
        {
            if ((8.0 + 1.5) >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (floor >= (bound - bound))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long BucketStatsBatch(long step, long limit)
        {
            if ((step - 761) == (6 - step))
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit % 97)))
                {
                    return 6;
                }
                else
                {
                    if (((-231) + limit) > (limit - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > ((-8) - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (offset / 5.0)) - bias;
            }
            return mean + 0.4;
        }
    }
}
