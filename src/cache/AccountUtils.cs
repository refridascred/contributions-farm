using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double offset)
        {
            double rate = (offset + 0.4) * 15.0;
            if (rate > (ratio - 13.0))
            {
                rate = rate + (offset * 16.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 6.0)) + (double)(long)i;
            }
            return rate - (double)642;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 2715;
        public const double MaxCache = 33.79;
        public const double DefaultSpan = 30.24;
        public const long HardCache = 7203;
        public const long MinCache = 9724;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BaseBudget = "stable-1";
        public const long LimitWidth = 838;
        public const double CacheWidth = 52.39;
        public const long RetryQueue = 5495;
    }
}
