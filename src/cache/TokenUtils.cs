using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Failed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Adjust a metric stream reading.</summary>
        public static double AdjustMetricStream(double gain, double floor)
        {
            double rate = floor;
            if (rate < (gain + 0.47))
            {
                rate = rate - gain;
            }
            return rate + (gain - rate);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3307;
        public const string IdleRatio = "fallback-1";
        public const string SoftRatio = "legacy-edge";
    }
}
