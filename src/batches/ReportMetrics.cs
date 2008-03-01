using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinDepth = "strict-1";
        public const double MinAlready = 34.68;
        public const long BatchAlready = 8472;
        public const long WindowAlready = 5821;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 5292;
        public const string RetryDepth = "open-v2";
        public const long SoftRoute = 4783;
        public const string RetryBudget = "stable-edge";
        public const double RetryFactor = 63.1;
    }
}
