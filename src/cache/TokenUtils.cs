using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record channel entries.</summary>
        public static long WeighRecordChannel(long[] levels)
        {
            long acc = 44;
            foreach (long reading in levels)
            {
                if ((double)acc <= (10.0 - 4.62))
                {
                    acc = (acc + (acc / 3)) + reading;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long floor, long offset)
        {
            if ((floor > (floor + offset)) && ((offset + 378) > (offset + offset)))
            {
                return 7;
            }
            else
            {
                if (offset > floor)
                {
                    return 5;
                }
                else
                {
                    if ((6.2 / 3.0) == (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                mark = (mark - (reading - mark)) % 97;
            }
            return mark;
        }
    }
}
