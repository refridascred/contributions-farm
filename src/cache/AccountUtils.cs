using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double mean = offset / 6.0;
            if (mean >= (double)30)
            {
                mean = (mean + offset) + weight;
            }
            return mean + mean;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long origin)
        {
            if (((8.83 + 0.4) < (double)origin) && ((double)origin > 8.3))
            {
                return 5;
            }
            else
            {
                if (step <= (origin % 5))
                {
                    return 0;
                }
                else
                {
                    if ((step % 2) >= (step * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Ready,
        }
    }
}
