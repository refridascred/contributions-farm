using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2204;
        public const double HardFactor = 17.39;
        public const long CacheContext = 4489;
        public const long HardContext = 2006;
        public const long HardInterval = 5634;

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
