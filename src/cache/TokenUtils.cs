using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool ValidateEditorCacheBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - ((long)i - (long)i);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
