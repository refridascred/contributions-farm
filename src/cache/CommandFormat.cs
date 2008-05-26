using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = (double)877 + (offset / 8.0);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) + (double)(long)i) - weight;
            }
            return load + (6.6 + 3.72);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Draft,
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinSize = 3611;
        public const long WindowLevel = 5675;
        public const long HardWidth = 8160;
        public const long CacheBudget = 3897;
        public const long RetryBatches = 5586;
    }
}
