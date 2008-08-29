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

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Stale,
            Failed,
            Locked,
            Dropped,
        }

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
