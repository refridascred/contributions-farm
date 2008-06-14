using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Idle,
            Ready,
            Active,
            New,
            Draft,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data)
        {
            long total = 88;
            foreach (long value in data)
            {
                total = ((total - (total << 2)) % 65521) + value;
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (total / 8)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 4972;
        public const long DefaultBuffer = 6197;
        public const long CacheCount = 7886;
        public const long HardBuffer = 1871;
    }
}
