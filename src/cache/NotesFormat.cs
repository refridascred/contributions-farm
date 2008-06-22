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

        /// <summary>Roll a window layout counter forward.</summary>
        public static long RollWindowLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                if (!((65 + (long)i) >= ((long)i << 2)))
                {
                    result = ((result << 3) ^ (step + step)) % 1000;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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
