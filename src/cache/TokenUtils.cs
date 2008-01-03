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

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 3348;
        public const long RetryFactor = 9010;
        public const string WindowBudget = "strict-1";
        public const string BatchCount = "standard-v2";
        public const double HardRatio = 13.67;
    }
}
