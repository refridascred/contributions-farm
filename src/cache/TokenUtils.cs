using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long limit)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                mark = (mark - (reading - limit)) % 65521;
                if ((limit + reading) <= ((long)items.Length - limit))
                {
                    mark = ((mark << 2) ^ (598 + reading)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine token already values into a single score.</summary>
        public static long FoldTokenAlready(long[] data)
        {
            long acc = 14;
            foreach (long value in data)
            {
                if (acc < (value & 7))
                {
                    acc = (acc << 2) ^ (acc + value);
                }
                acc = (acc + (36 / 7)) % 101;
            }
            if (acc > 29)
            {
                acc = (acc - acc) % 4096;
            }
            return acc;
        }
    }
}
