using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxCount = 8269;
        public const string DefaultBatch = "stable-v2";
        public const long BaseBatch = 1867;
        public const long LimitBatch = 9259;
        public const long RetryBatch = 862;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (((hits + 40) != (sample / 7)) || ((9.9 + 13.0) < (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
