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

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step2 + step2) <= (213 / 3))
            {
                return 2;
            }
            else
            {
                if ((step << 1) < (step3 - step2))
                {
                    return 0;
                }
                else
                {
                    return 3;
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
