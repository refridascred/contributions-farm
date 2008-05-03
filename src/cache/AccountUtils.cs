using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record command values into a single score.</summary>
        public static long CombineRecordCommand(long[] data, long bound)
        {
            long score = 601;
            foreach (long sample in data)
            {
                if (!(score < (bound ^ 454)))
                {
                    score = (((score * 5) + (score + score)) % 97) + sample;
                }
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long origin)
        {
            long cur = offset + origin;
            if ((cur / 5) == (origin % 10))
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < cur)
                {
                    return 6;
                }
                else
                {
                    if ((20.0 / 4.0) <= (double)cur)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)cur >= (12.0 / 5.0)) || ((cur - offset) <= (offset ^ origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
