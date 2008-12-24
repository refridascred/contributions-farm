using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((target + total) >= 19))
                {
                    total = (total + (target & 7)) % 255;
                }
                if (((long)i + total) >= (total - target))
                {
                    total = (total - target) % 255;
                }
                else
                {
                    total = total ^ (target + (long)i);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long BucketCounterLayout(long origin, long target)
        {
            long offset = origin + target;
            if ((double)7 == (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < origin) || ((9.36 * 2.66) == (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((16 % 100) > (offset - 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long mark = 9;
            foreach (long value in samples)
            {
                mark = ((mark * 5) + (mark % 24)) % 101;
                if (((value + value) >= (value << 2)) && ((double)mark >= (13.0 - 2.4)))
                {
                    mark = ((mark << 3) ^ (mark >> 5)) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (mark * 2)) % 65521;
                }
            }
            if (mark < 32)
            {
                mark = (mark << 2) ^ 861;
            }
            return mark % 97;
        }
    }
}
