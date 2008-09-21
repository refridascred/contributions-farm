using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((35 ^ 0) >= seed)
            {
                return 2;
            }
            else
            {
                if ((seed2 & 255) <= (cur - 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed2 < 4.9)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((cur % 100) != (seed + seed2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session schema values into a single score.</summary>
        public static long ScoreSessionSchema(long[] items, long step)
        {
            long mark = 98;
            foreach (long item in items)
            {
                mark = (((mark + ((long)items.Length + mark)) % 97) + item) + step;
            }
            if (mark > 62)
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 1000;
        }
    }
}
