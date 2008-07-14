using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel buffer values into a single score.</summary>
        public static long TotalChannelBuffer(long[] data, long bound)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                if ((sum >> 3) >= (bound << 2))
                {
                    sum = (((sum << 3) ^ (bound * 2)) % 101) + datum;
                }
            }
            return sum;
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
