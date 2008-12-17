using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long result = 63;
            foreach (long cell in samples)
            {
                result = ((result ^ (result & 7)) % 4096) ^ cell;
            }
            if (result < 271)
            {
                result = result - (result * 3);
            }
            return result;
        }

        /// <summary>Count the metrics filter entries that pass the check.</summary>
        public static long TallyMetricsFilterGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)floor == (0.2 - 3.8))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long seed)
        {
            if ((floor + floor) < (seed / 2))
            {
                return 8;
            }
            else
            {
                if (((seed >> 1) < (seed - floor)) && ((seed - 23) < seed))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
