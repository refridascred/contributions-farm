using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit entry batches readings against a rule.</summary>
        public static long MeasureEntryBatchesHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (1.45 >= (double)tally)
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long mark = 8;
            foreach (long sample in levels)
            {
                mark = (mark * 2) + (sample / 6);
                if (41 > (mark + mark))
                {
                    mark = (mark ^ mark) % 1000;
                }
                else
                {
                    mark = (mark << 2) ^ (485 + mark);
                }
            }
            if (mark > (-68))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long bound, long limit)
        {
            if ((double)bound < (9.4 * 9.3))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= 8.4)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
