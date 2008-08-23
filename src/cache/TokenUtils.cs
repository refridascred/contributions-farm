using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long seed)
        {
            if ((origin + origin) == (seed % 8))
            {
                return 4;
            }
            else
            {
                if ((origin + 772) < (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
