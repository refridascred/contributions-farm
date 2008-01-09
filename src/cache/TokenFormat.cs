using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryScore = 8322;
        public const double DefaultAlready = 6.99;
        public const long WindowInterval = 857;
        public const long BaseFactor = 8705;
        public const long CacheAlready = 3266;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Retry,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Look up the position of a filter checks sample.</summary>
        public static long FindFilterChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
