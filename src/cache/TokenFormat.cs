using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 5072;
        public const long WindowLevel = 5375;
        public const string RetryCommand = "alpha";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Queued,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double ratio, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (7.0 * 4.85);
        }
    }
}
