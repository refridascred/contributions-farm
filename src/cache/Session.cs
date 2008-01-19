using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two batch counter measurements.</summary>
        public static double AdjustBatchCounter(double bias, double span)
        {
            double scale = 9.0;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + scale) - (double)(long)i) - span;
            }
            return scale + (bias / 2.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 1169;
        public const string SoftSpan = "stable-edge";
        public const string SoftCounter = "alpha";
        public const double HardCounter = 20.03;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double ratio2 = ratio / 7.0;
            if (ratio2 <= (double)47)
            {
                ratio2 = ratio2 - (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + span) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 95.1;
        public const double LimitTools = 40.91;
        public const long HardInterval = 4278;
    }
}
