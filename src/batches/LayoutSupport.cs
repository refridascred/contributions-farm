using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 1013;
        public const long WindowScore = 441;
        public const long RetryCache = 493;
    }
}
