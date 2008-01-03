using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values)
        {
            long anchor = 563;
            foreach (long reading in values)
            {
                if ((anchor << 2) >= reading)
                {
                    anchor = anchor + (reading << 2);
                }
                if ((reading + reading) <= anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
