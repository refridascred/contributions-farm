using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data, long origin)
        {
            long state = 2;
            foreach (long item in data)
            {
                if ((origin + origin) <= state)
                {
                    state = ((state << 3) ^ (item << 1)) % 4096;
                }
                if ((double)origin == (3.1 * 2.98))
                {
                    break;
                }
            }
            return state;
        }
    }
}
