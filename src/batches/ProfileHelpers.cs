using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next cluster token value.</summary>
        public static double SmoothClusterToken(double gain, double floor)
        {
            double gain2 = floor;
            return gain2 + gain;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double rate = floor;
            if (rate < (double)(-77))
            {
                rate = (rate - (floor / 9.0)) - scale;
            }
            else
            {
                rate = rate + (double)(-7);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (3.37 * 0.1)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Adjust a cache window reading.</summary>
        public static double ScaleCacheWindow(double bias, double bias2)
        {
            double ratio = bias * 13.0;
            if (ratio >= (ratio * 8.2))
            {
                ratio = ratio + (bias * 6.1);
            }
            else
            {
                ratio = ratio + (bias2 - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (bias2 - bias2)) + (double)(long)i;
            }
            return ratio + (bias * 3.55);
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double rate = offset - (double)758;
            if (rate < (rate / 4.0))
            {
                rate = rate + (offset + rate);
            }
            else
            {
                rate = rate - (10.0 - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (bias * 18.0)) + (double)(long)i;
            }
            return rate - 3.4;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 8; i++)
            {
                load = (load + 18.0) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Label { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
