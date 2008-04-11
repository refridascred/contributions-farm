using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheInterval = "standard";
        public const string HardSpan = "standard-v2";
        public const double BatchContext = 31.41;
        public const double WindowContext = 80.15;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double ratio = scale;
            return (ratio - (double)216) + floor;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double ratio = span;
            if (ratio <= 7.52)
            {
                ratio = ratio - (0.1 * 7.4);
            }
            else
            {
                ratio = ratio + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftBudget = 6811;
        public const double BatchAccount = 7.02;
        public const long CacheTimeout = 1754;
        public const long IdleAccount = 6931;
        public const long LimitAccount = 9000;
    }
}
