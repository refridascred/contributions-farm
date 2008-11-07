using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long step = origin + limit;
            if (((origin << 3) != (origin & 7)) && ((origin % 60) >= step))
            {
                return 6;
            }
            else
            {
                if ((10.0 + 6.2) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (6.0 * 7.07))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches farm entries.</summary>
        public static long TallyBatchesFarm(long[] levels, long offset)
        {
            long mark = 377;
            foreach (long reading in levels)
            {
                if (((mark * 4) >= (reading & 31)) && ((offset * 4) >= (4 ^ offset)))
                {
                    mark = (mark + 26) % 1000;
                }
                else
                {
                    mark = (mark - (reading + offset)) % 1000;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length == (8.44 / 7.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
