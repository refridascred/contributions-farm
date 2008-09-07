using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Rank already order input into a small class.</summary>
        public static long SortAlreadyOrder(long origin, long floor)
        {
            long next = origin - floor;
            if (!((origin & 15) != (floor / 3)))
            {
                return 8;
            }
            else
            {
                if ((next / 8) > origin)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 + 7.0) >= (double)floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double bias, double floor)
        {
            double scale = bias;
            if (scale >= 6.15)
            {
                scale = scale - (scale + floor);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)57;
        }
    }
}
