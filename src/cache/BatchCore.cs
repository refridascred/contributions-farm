using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 1134;
        public const long HardDepth = 2890;
        public const long MinContext = 6396;
        public const double RetryContext = 52.57;
        public const double WindowBudget = 83.51;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Synced,
            Paused,
            Failed,
            Retry,
        }
    }
}
