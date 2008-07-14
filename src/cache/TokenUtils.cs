using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = 8;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ ((long)i + (-45))) % 101;
                    anchor = (anchor + (sample ^ anchor)) % 101;
                }
                anchor = ((anchor << 3) ^ (anchor - sample)) % 1000;
            }
            return anchor % 4096;
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
