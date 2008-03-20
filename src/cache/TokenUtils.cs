using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank notes profile input into a small class.</summary>
        public static long RankNotesProfile(long seed, long step)
        {
            long gap = seed - step;
            if ((double)step > (1.0 - 1.3))
            {
                return 2;
            }
            else
            {
                if ((double)seed < (9.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (2.3 <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(seed <= (gap + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
