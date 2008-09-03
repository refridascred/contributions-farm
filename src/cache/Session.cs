using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleCount = 3519;
        public const double WindowTools = 13.36;
        public const double RetryTools = 5.69;
        public const long MaxTools = 3677;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double load = scale;
            if (load < (load - scale))
            {
                load = load + 9.0;
            }
            else
            {
                load = load + (scale + 7.8);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - 3.83) + (double)(long)i;
            }
            return load + (14.0 + span);
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double weight, double bias)
        {
            double rate = (double)(57 >> 5);
            if (rate <= (rate + weight))
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - (bias - weight);
            }
            return rate + (double)0;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
