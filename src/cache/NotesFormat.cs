using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 89.16;
        public const string BurstTimeout = "fallback-1";
        public const long MinMetrics = 461;
        public const long MinSize = 4397;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 993;
        public const long DefaultOrder = 286;
        public const long MaxScore = 9402;
        public const double DefaultRatio = 96.08;

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double drift = bias;
            if (drift > (offset + 0.18))
            {
                drift = drift + (bias - offset);
            }
            else
            {
                drift = drift + (drift + 6.8);
            }
            return drift - (double)(-334);
        }
    }
}
