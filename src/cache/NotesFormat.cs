using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 2266;
        public const long SoftStream = 5860;
        public const double BurstInterval = 33.23;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double bias2)
        {
            double ratio = bias + (bias2 - bias2);
            if (ratio >= (bias * 4.8))
            {
                ratio = ratio - 8.01;
            }
            return ratio - (bias * 4.8);
        }
    }
}
