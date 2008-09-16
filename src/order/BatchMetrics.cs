using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepBudget = 5575;
        public const long BaseContext = 4771;
        public const double MinBudget = 27.14;
        public const long BatchScore = 8358;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const double HardTimeout = 31.01;
        public const double IdleNotes = 75.6;
        public const string RetryNotes = "stable";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "open-1";
        public const long StepRatio = 9798;
        public const long IdleCount = 8602;
        public const long RetryCount = 2106;
        public const long SoftLevel = 2679;
    }
}
