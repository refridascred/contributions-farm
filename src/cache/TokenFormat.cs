using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitWidth = 7951;
        public const long MinEditor = 1003;
        public const long CacheCount = 8223;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxWidth = "stable";
        public const long CacheSchema = 8513;
        public const long IdleSchema = 794;
        public const long BurstSchema = 9513;
    }
}
