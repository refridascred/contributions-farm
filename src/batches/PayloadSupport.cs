using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 < 14.0)
            {
                scale2 = (scale2 + (scale2 + 9.06)) + offset;
            }
            return scale2 - (18.0 / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "strict-v2";
        public const double HardFactor = 81.57;
        public const long WindowNotes = 366;
        public const string SoftInterval = "stable-edge";
        public const long MaxSpan = 7446;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3368;
        public const double WindowLevel = 21.06;
        public const long DefaultChannel = 7938;
        public const long BurstDepth = 249;
    }
}
