using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftCount = 97.41;
        public const double MaxLevel = 67.5;
        public const long MaxWidth = 5147;
        public const double SoftRatio = 55.98;
        public const long HardEditor = 7034;

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = bias;
            return (scale + bias) + rate;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Active,
            Synced,
            Idle,
            Pending,
        }
    }
}
