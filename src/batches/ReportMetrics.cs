using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "stable-1";
        public const long WindowSize = 1267;
        public const long BatchDepth = 2224;
        public const long BurstTimeout = 8934;
        public const long WindowNotes = 1942;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "alpha-v2";
        public const long BaseQueue = 4466;
        public const string MinScore = "primary-v2";
        public const long MinInterval = 861;

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7379;
        public const long BaseTools = 5084;
        public const double HardTools = 49.23;
        public const long BatchInterval = 3488;
        public const string RetryTools = "standard";
    }
}
