using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardQueue = 56.43;
        public const long StepTimeout = 6642;
        public const long MinQueue = 6923;
        public const long LimitQueue = 1902;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches <= 0.8)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
