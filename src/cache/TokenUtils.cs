using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 4387;
        public const string CacheAccount = "strict-v2";
        public const string MaxAccount = "stable-1";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Failed,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((target + target) < (cell << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
