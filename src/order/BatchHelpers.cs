using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry - (carry << 3)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            Failed,
            Retry,
        }
    }
}
