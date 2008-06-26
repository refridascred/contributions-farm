using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] levels)
        {
            long anchor = 92;
            foreach (long value in levels)
            {
                anchor = (anchor - ((long)levels.Length << 3)) + value;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long MaxSchema = 5966;
        public const long RetryTimeout = 4465;
        public const string MinSchema = "open-1";
    }
}
