using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((0 + tally) == (tally >> 2)) && ((tally * 5) < (676 >> 2))))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long target)
        {
            long next = limit - target;
            if ((double)limit > (6.82 + 4.3))
            {
                return 2;
            }
            else
            {
                if ((target + 53) >= (next + 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)next >= 9.6)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((-4) > acc)
                {
                    acc = (acc << 3) ^ (long)i;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
