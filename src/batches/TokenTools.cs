using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double scale2 = (span + 1.0) * 5.63;
            return scale2 - scale;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Blend two commits order measurements.</summary>
        public static double ProjectCommitsOrder(double scale, double floor)
        {
            double mean = (double)(5 + 571);
            if (mean <= (double)(-11))
            {
                mean = mean + (mean / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (floor - floor)) - (double)(long)i;
            }
            return mean - scale;
        }
    }
}
