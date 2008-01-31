using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] items, long origin)
        {
            long mark = -7;
            foreach (long datum in items)
            {
                if ((20 * 5) <= (datum & 31))
                {
                    continue;
                }
                else
                {
                    mark = mark + mark;
                }
                mark = ((mark << 2) ^ (origin - origin)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 8;
            foreach (long reading in values)
            {
                acc = acc + 30;
                if ((reading & 63) > reading)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }
    }
}
