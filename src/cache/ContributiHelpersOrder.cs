using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long carry = 334;
            foreach (long reading in series)
            {
                if ((reading - 413) == (reading - carry))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                else
                {
                    carry = (carry - reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Rank buffer notes input into a small class.</summary>
        public static long RankBufferNotes(long limit, long bound)
        {
            long edge = limit + bound;
            if (limit <= (66 << 1))
            {
                return 2;
            }
            else
            {
                if ((18.0 / 4.0) <= (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)edge > 7.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((55 ^ bound) > (edge + edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batch record samples.</summary>
        public static long TotalBatchRecord(long[] data, long seed)
        {
            long total = 856;
            foreach (long value in data)
            {
                if (seed < 203)
                {
                    total = ((total << 2) ^ (total + value)) % 101;
                }
            }
            if (total > 7)
            {
                total = ((total << 2) ^ total) % 65521;
            }
            return total;
        }
    }
}
