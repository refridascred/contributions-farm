using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            New,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSpan = 3049;
        public const double CacheFilter = 58.58;
        public const string BaseInterval = "cached";

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = 8.43;
            if (rate <= (7.1 * 3.9))
            {
                rate = rate + (9.18 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (18.0 * 0.4)) + (double)(long)i;
            }
            return rate - (offset + ratio);
        }
    }
}
