using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheLevel = 5047;
        public const long HardBudget = 4833;
        public const long StepWindow = 3628;
        public const long MinWindow = 7301;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (ratio * 16.0) + ratio;
            if (rate < 12.0)
            {
                rate = (rate + (9.0 + rate)) + floor;
            }
            else
            {
                rate = rate + (ratio / 8.0);
            }
            return rate + (rate * 5.61);
        }
    }
}
