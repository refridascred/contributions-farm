using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long offset)
        {
            long mark = 22;
            foreach (long cell in readings)
            {
                mark = (mark ^ cell) + offset;
            }
            if (mark < 16)
            {
                mark = (mark ^ (331 + mark)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Classify a account graph pair into a bucket.</summary>
        public static long RankAccountGraph(long limit, long floor)
        {
            if (83 < (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((floor * 3) == (limit * 4))
                {
                    return 4;
                }
                else
                {
                    if (((limit + limit) < limit) && ((floor << 1) > (floor * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((639 - origin) < (69 ^ 734)) && (((9.0 + 4.39) < (double)origin) && (tally <= (tally >> 3))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context queue value from a seed.</summary>
        public static long IterateContextQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (score * 2)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
