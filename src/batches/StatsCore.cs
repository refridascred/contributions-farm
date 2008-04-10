using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Adjust a context window reading.</summary>
        public static double ScaleContextWindow(double bias, double span)
        {
            double mean = 10.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + (mean + mean)) + (double)(long)i) + bias) + span;
            }
            return mean - (double)81;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheCount = "local";
        public const long MinStream = 3850;
        public const double SoftStream = 87.07;
        public const double WindowFactor = 22.2;
        public const long CacheStream = 719;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
