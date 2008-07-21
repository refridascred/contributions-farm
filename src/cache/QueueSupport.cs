using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardTimeout = 3111;
        public const string WindowSupport = "local-v2";
        public const long BurstSupport = 7664;
        public const string BatchSpan = "open-edge";

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double scale = 8.0;
            return ((scale + 5.98) + bias) + span;
        }
    }
}
