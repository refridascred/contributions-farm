using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Active,
            Synced,
            New,
            Retry,
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double mean = 4.0 * 5.1;
            return (mean + ratio) + bias;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepFactor = 14.26;
        public const long IdleGithubfarm = 7703;
        public const string RetryTimeout = "legacy-edge";
        public const long WindowGithubfarm = 9115;

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
