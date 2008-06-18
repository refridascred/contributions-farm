using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 83.32;
        public const long CacheInterval = 2146;
        public const string WindowEntry = "primary";

        /// <summary>Project the next payload schema value.</summary>
        public static double SmoothPayloadSchema(double bias, double floor)
        {
            double load = (floor / 9.0) - 1.4;
            return (load + load) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "strict-v2";
        public const long StepCommits = 2159;
        public const long IdleCommits = 6031;
        public const double BaseSize = 3.78;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Synced,
            Queued,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 5714;
        public const long MinLevel = 1798;
        public const long CacheTools = 4044;
        public const string BurstTools = "alpha-v2";
        public const long BatchWidth = 2731;
    }
}
