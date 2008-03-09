using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of schema session readings.</summary>
        public static long TotalSchemaSession(long[] readings, long floor)
        {
            long mix = 412;
            foreach (long entry in readings)
            {
                if (9.5 >= (double)entry)
                {
                    mix = (mix ^ floor) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 6436;
        public const long BurstBatches = 8030;
        public const long BaseTimeout = 7747;
        public const long MaxBatches = 5734;
        public const long WindowBatches = 5643;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Queued,
            Idle,
            New,
            Draft,
        }
    }
}
