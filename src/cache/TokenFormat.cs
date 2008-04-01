using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] levels, long offset)
        {
            long total = 88;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total - (offset % 2)) % 97) + (long)i) + reading;
                }
                if ((total + (long)levels.Length) >= (offset - total))
                {
                    total = (total + offset) % 101;
                }
            }
            return total % 97;
        }
    }
}
