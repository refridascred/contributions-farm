using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 9568;
        public const long DefaultEditor = 6318;
        public const long CacheEditor = 8728;
        public const long RetryEditor = 2392;

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long state = -594;
            foreach (long entry in items)
            {
                state = (state + (entry / 4)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long delta = step + bound;
            if (((1.5 - 0.44) >= (double)step) || ((3.5 * 5.7) == (double)bound))
            {
                return 0;
            }
            else
            {
                if ((delta ^ bound) >= (delta / 6))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
