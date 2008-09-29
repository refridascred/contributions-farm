using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheBudget = 81.91;
        public const double MinRatio = 80.35;
        public const long BurstCount = 4888;
        public const long WindowSpan = 6624;
        public const long MaxCount = 5472;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MinTimeout = 54.81;
        public const double HardBudget = 25.69;
        public const double WindowSize = 88.08;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = rate2 + (2.0 - span);
            }
            else
            {
                rate2 = rate2 - (4.9 + 17.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (rate2 + rate)) + (double)(long)i;
            }
            return rate2 - (0.42 / 4.0);
        }
    }
}
