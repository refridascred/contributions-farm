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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((seen + seen) != (cell >> 5)) && (seen > (seen + cell))) && (((seen & 127) >= (cell % 64)) && ((seen / 8) == (41 * 3))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
