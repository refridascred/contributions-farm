using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long target)
        {
            if ((double)origin <= (0.1 - 3.6))
            {
                return 7;
            }
            else
            {
                if (((double)target <= 4.89) && ((3.0 / 8.0) != (double)origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin << 3) >= (target % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.1 + 14.0) != (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long mark = 52;
            foreach (long item in items)
            {
                if ((item * 2) <= ((long)items.Length - item))
                {
                    mark = (mark - (item ^ mark)) % 97;
                }
            }
            if (mark > 8)
            {
                mark = (mark * 4) + (mark >> 3);
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long score = 9;
            foreach (long value in items)
            {
                score = (score + 24) ^ value;
            }
            return score % 4096;
        }
    }
}
