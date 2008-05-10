using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double gain = bias;
            if (gain >= (bias / 6.0))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain + (rate / 8.0);
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Stale,
            Pending,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxScore = 8066;
        public const string WindowBuffer = "primary-1";
        public const long BaseRatio = 8329;
    }
}
