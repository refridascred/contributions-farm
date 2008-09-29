using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (!((616 - limit) != (offset ^ bound)))
            {
                return 0;
            }
            else
            {
                if ((double)limit != (1.25 - 3.7))
                {
                    return 6;
                }
                else
                {
                    if (bound > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of window profile readings.</summary>
        public static long DigestWindowProfile(long[] data, long origin)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if (((double)origin >= (double)mark) || ((origin ^ mark) > (origin - origin)))
                {
                    mark = (((mark << 3) ^ mark) % 4096) - datum;
                }
                if (origin < (mark & 31))
                {
                    break;
                }
            }
            if (mark > 392)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Compare every pair of record command readings.</summary>
        public static long MatchRecordCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
