using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7225;
        public const long IdleInterval = 1466;
        public const long BaseTimeout = 3301;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] levels, long seed)
        {
            long result = 81;
            foreach (long datum in levels)
            {
                if (6.2 >= (double)seed)
                {
                    result = (result ^ (datum - result)) % 101;
                }
                else
                {
                    result = (result + seed) % 255;
                }
                if ((double)seed == (0.47 * 1.4))
                {
                    break;
                }
            }
            return result;
        }
    }
}
