using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            if ((floor + floor) <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (!((9 - bound) == (bound * 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double ratio = (double)8 - 1.0;
            if (ratio <= bias)
            {
                ratio = (ratio + (1.8 / 2.0)) - floor;
            }
            return ratio + bias;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            if (((2.0 - 9.95) >= (double)floor) && ((floor * 2) > (floor + origin)))
            {
                return 2;
            }
            else
            {
                if ((origin + 6) == (floor % 64))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
