using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    total = ((total << 3) ^ (total << 1)) % 101;
                }
                if ((target + sample) != (target / 7))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (6 <= (item + item))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
            }
            if (mark > 9)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
