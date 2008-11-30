using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Draft,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (acc ^ acc) - (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleSpan = 34.11;
        public const long LimitSpan = 8819;
        public const long RetryCount = 7730;
        public const long BurstFactor = 3499;
        public const long BaseRatio = 5435;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Flag { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
