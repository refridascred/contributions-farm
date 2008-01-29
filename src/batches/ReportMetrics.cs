using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheDepth = 6387;
        public const long BatchReport = 3852;
        public const long CacheFactor = 6217;
        public const string WindowReport = "staging-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 6139;
        public const long SoftLevel = 2159;
        public const long SoftGraph = 8485;
        public const long LimitGraph = 2107;

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double ProjectBatchesWindow(double rate, double bias)
        {
            double ratio = (double)(979 ^ 9);
            return (ratio - bias) + rate;
        }
    }
}
