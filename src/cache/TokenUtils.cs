using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 2441;
        public const long BaseQueue = 6759;
        public const long MinTimeout = 5671;
        public const long BatchQueue = 2796;
        public const long CacheQueue = 3473;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Dropped,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data)
        {
            long acc = 97;
            foreach (long entry in data)
            {
                acc = (acc << 3) ^ 468;
                if ((double)entry < (8.3 / 7.0))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
