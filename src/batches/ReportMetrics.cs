using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double bias2 = (double)813 / 3.0;
            if (bias2 >= bias2)
            {
                bias2 = ((bias2 + (1.7 * 1.4)) - rate) + bias;
            }
            return bias2 - 20.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 9119;
        public const long BaseSize = 1371;
        public const string BatchBatches = "strict-edge";
        public const long MinSize = 6214;
        public const double CacheBatches = 69.09;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Stale,
            New,
            Active,
        }
    }
}
