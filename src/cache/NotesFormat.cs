using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long seed)
        {
            if (((97 % 16) == (target / 4)) && (((-4) + target) == (751 ^ 98)))
            {
                return 6;
            }
            else
            {
                if ((29 << 3) > (target + seed))
                {
                    return 8;
                }
                else
                {
                    if (1.2 <= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)target >= 9.32)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel report samples.</summary>
        public static long ScoreChannelReport(long[] readings, long floor)
        {
            long result = -61;
            foreach (long cell in readings)
            {
                if ((floor >> 4) == (result % 5))
                {
                    result = ((result - (result << 2)) % 97) ^ cell;
                }
                if (!(result <= (result - 5)))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
