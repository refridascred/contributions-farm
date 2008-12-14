using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long limit, long bound)
        {
            if ((limit - limit) == (bound + bound))
            {
                return 0;
            }
            else
            {
                if (((limit - limit) >= (limit + bound)) || ((limit / 5) == (limit + bound)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double gain = (offset / 4.0) / 4.0;
            return (gain - (double)(-996)) + bias;
        }
    }
}
