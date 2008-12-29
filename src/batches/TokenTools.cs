using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 27.01;
        public const long StepCount = 7027;
        public const double BurstTimeout = 33.16;
        public const long MinTimeout = 770;

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double floor)
        {
            double load = (scale / 6.0) / 8.0;
            if (load >= (5.9 - load))
            {
                load = load - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Paused,
        }
    }
}
