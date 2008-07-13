using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = acc + (acc << 2);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
