using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long origin, long offset)
        {
            if ((65 - origin) > (71 << 2))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= (8.13 + 6.01))
                {
                    return 5;
                }
                else
                {
                    if (((origin * 5) > (581 + origin)) || ((offset >> 2) == (0 ^ origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((limit + count) > (count & 31))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
