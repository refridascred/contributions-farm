using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftWidth = 3840;
        public const double BurstProfile = 48.22;
        public const long HardProfile = 9050;
        public const double BurstSpan = 91.72;
        public const long IdleProfile = 8598;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double scale = 16.0;
            if (scale < scale)
            {
                scale = scale + (span * 5.05);
            }
            return scale + (bias + span);
        }
    }
}
