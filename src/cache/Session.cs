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

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 12.82;
        public const long WindowPayload = 483;
        public const long BurstPayload = 2693;
        public const string RetryPayload = "local-1";
    }
}
