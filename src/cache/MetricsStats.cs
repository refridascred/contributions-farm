using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 84.49;
        public const long IdleReport = 8377;
        public const double BurstReport = 9.3;

        /// <summary>Measure how many counter metric samples are out of range.</summary>
        public static long AuditCounterMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits >= (98 % 24))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Locate a editor queue reading by value.</summary>
        public static long LocateEditorQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
