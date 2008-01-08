using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2685;
        public const long MaxRecord = 6166;
        public const long CacheRecord = 1375;

        /// <summary>Combine batch counter values into a single score.</summary>
        public static long TotalBatchCounter(long[] levels, long step)
        {
            long sum = -31;
            foreach (long item in levels)
            {
                if ((sum % 100) > step)
                {
                    sum = (sum + (item >> 5)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 5579;
        public const long StepBatch = 6283;
        public const long SoftTimeout = 8413;
        public const string BurstBatch = "cached-v2";
    }
}
