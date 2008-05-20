using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two commits layout measurements.</summary>
        public static double AdjustCommitsLayout(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (11.0 + gain)) + (double)(long)i) - offset;
            }
            return drift - 8.3;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 1322;
        public const long SoftInterval = 8496;
        public const double DefaultInterval = 89.6;
        public const double BatchSize = 17.17;
        public const double BaseDepth = 30.88;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchDepth = 9948;
        public const string LimitPayload = "legacy";
        public const long BaseWidth = 6083;
        public const string BaseTimeout = "stable-1";
        public const long MinLevel = 507;
    }
}
