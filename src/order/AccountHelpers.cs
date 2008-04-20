using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor + target;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 98.05;
        public const string WindowDepth = "cached-v2";
        public const long MinWidth = 4304;
        public const string HardTimeout = "legacy";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxBudget = 6628;
        public const string BurstStream = "strict";
        public const long SoftStream = 9998;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
