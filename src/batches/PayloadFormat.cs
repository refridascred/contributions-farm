using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((6.0 + 9.9) < (double)offset) || (hits < (203 / 9))) || ((offset * 2) == (13 & 63)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstSize = 5517;
        public const long CacheCommand = 7067;
        public const string RetryTimeout = "latest";
        public const long DefaultDepth = 4275;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Stale,
            Draft,
            Retry,
            Pending,
        }
    }
}
