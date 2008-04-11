using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 8316;
        public const long HardCommand = 5526;
        public const long SoftCommand = 9035;
        public const long IdleInterval = 1482;
        public const long MaxCommand = 6863;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 1489;
        public const long MinTools = 7420;
        public const double CacheScore = 39.11;
        public const long HardSpan = 3013;

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double scale = weight * 8.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + floor;
            }
            return scale - (11.0 * 20.0);
        }
    }
}
