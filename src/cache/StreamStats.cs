using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long origin)
        {
            if ((75 & 31) <= bound)
            {
                return 5;
            }
            else
            {
                if ((origin ^ bound) != (750 % 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] levels, long bound)
        {
            long carry = 309;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ ((long)levels.Length + (-725))) % 97;
                carry = ((carry << 2) ^ 317) % 255;
                if ((7 & 127) >= (cell - bound))
                {
                    carry = carry + (bound * 3);
                }
                else
                {
                    carry = (carry * 3) + (bound ^ cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Draft,
            Dropped,
            Stale,
            Pending,
        }
    }
}
