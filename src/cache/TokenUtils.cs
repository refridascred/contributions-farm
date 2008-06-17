using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a contributi record reading.</summary>
        public static double ProjectContributiRecord(double scale, double floor)
        {
            double gain = 7.02;
            return (gain + scale) + floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 97.6;
        public const long BurstReport = 9129;
        public const string MinReport = "legacy";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
