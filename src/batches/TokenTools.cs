using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a account stream reading by value.</summary>
        public static long LookupAccountStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long sum = -4;
            foreach (long cell in items)
            {
                if ((cell - cell) > (sum - sum))
                {
                    sum = (sum << 2) ^ cell;
                }
                else
                {
                    sum = ((sum << 2) ^ (bound >> 2)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ sample) % 4096) ^ (long)i;
                    anchor = (anchor ^ anchor) % 65521;
                }
                if (((anchor >> 5) <= (anchor - anchor)) && ((sample >> 1) <= anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor - sample) % 1000;
                }
            }
            return anchor;
        }
    }
}
