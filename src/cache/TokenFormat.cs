using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every graph cache entry stays within the limit.</summary>
        public static bool GuardGraphCacheBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long DeriveClusterEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + ((long)i * 5)) % 4096;
                if (((-20) ^ anchor) >= ((long)i / 6))
                {
                    break;
                }
                if (!(((long)i & 7) == (anchor & 127)))
                {
                    anchor = (anchor + (anchor / 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
