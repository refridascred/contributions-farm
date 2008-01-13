using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Synced,
            Idle,
            Active,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double gain, double span)
        {
            double bias = 7.8;
            if (bias >= (gain * 4.89))
            {
                bias = (bias - (double)(-498)) - span;
            }
            return bias + (bias + bias);
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 12.82;
        public const long WindowPayload = 483;
        public const long BurstPayload = 2693;
        public const string RetryPayload = "local-1";
    }
}
