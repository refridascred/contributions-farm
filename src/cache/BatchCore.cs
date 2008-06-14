using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultLevel = "standard-v2";
        public const long WindowSize = 5920;
        public const double BaseSpan = 65.65;

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double scale, double floor)
        {
            double bias = (double)(-19) - (scale * 5.4);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias + (double)562) + (double)(long)i) - floor;
            }
            return bias - scale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 4563;
        public const long BurstSpan = 2959;
        public const long BatchEditor = 435;
        public const long DefaultFactor = 8233;
        public const long BaseEditor = 9329;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Draft,
            Active,
        }
    }
}
