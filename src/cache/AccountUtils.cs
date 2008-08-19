using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total << 2) ^ (long)i;
                if ((step << 1) <= total)
                {
                    total = (total * 5) + total;
                    total = (total + (step >> 1)) % 97;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long origin, long floor)
        {
            long diff = origin + floor;
            if (!((66 - 35) >= floor))
            {
                return 8;
            }
            else
            {
                if ((floor / 6) >= (diff - origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) != (floor >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor >> 5) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
