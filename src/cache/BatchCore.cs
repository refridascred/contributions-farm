using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowDepth = 4.35;
        public const long CacheQueue = 8303;
        public const long StepRatio = 3051;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
