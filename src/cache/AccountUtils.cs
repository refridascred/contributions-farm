using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long limit, long origin)
        {
            long diff = limit ^ origin;
            if ((limit / 8) < diff)
            {
                return 6;
            }
            else
            {
                if (origin >= (76 ^ limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double ratio = (span * 9.96) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 6.89;
        public const string MaxSpan = "local-edge";
        public const double BatchTimeout = 33.38;
    }
}
