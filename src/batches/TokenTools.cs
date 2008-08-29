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

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 3275;
        public const string BaseBudget = "legacy-v2";
        public const long DefaultTimeout = 1506;

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
