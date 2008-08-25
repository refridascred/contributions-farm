using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long offset)
        {
            long offset2 = step ^ offset;
            if ((step - offset2) > ((-930) >> 1))
            {
                return 6;
            }
            else
            {
                if (((offset2 / 8) >= (4 - step)) && ((0 + step) <= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if (offset >= (offset + step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate stats farm readings against a bound.</summary>
        public static bool GuardStatsFarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Retry,
            Closed,
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long DigestProfileBuffer(long[] samples, long origin)
        {
            long mark = 69;
            foreach (long value in samples)
            {
                if (7.79 >= (double)value)
                {
                    mark = (mark * 5) + (origin ^ mark);
                }
            }
            if (mark > 404)
            {
                mark = ((mark << 2) ^ (365 >> 2)) % 101;
            }
            return mark % 65521;
        }
    }
}
