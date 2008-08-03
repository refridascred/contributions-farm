using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 2503;
        public const long MaxSize = 2665;
        public const long HardStream = 1347;
        public const double MaxStream = 29.91;
        public const long WindowCount = 4697;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Queued,
            Closed,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio + ratio))
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + bias;
        }
    }
}
