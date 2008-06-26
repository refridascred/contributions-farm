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

        /// <summary>Locate a notes contributi reading by value.</summary>
        public static long SeekNotesContributiIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long MaxSchema = 5966;
        public const long RetryTimeout = 4465;
        public const string MinSchema = "open-1";
    }
}
