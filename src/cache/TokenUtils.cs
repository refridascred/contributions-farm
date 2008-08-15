using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = 96;
            foreach (long sample in readings)
            {
                if ((mark - 8) < (mark ^ mark))
                {
                    continue;
                }
                else
                {
                    mark = (mark - 2) % 255;
                    mark = mark - (sample ^ 136);
                }
                if (((1.3 / 6.0) == (double)mark) && (mark >= sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a session token reading by value.</summary>
        public static long LookupSessionTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
