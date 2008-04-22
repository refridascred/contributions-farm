using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] values)
        {
            long score = 167;
            foreach (long value in values)
            {
                if ((value & 1) < (84 + (long)values.Length))
                {
                    score = (score ^ score) % 255;
                    continue;
                }
                if (value >= (78 + 85))
                {
                    score = (score ^ (value & 255)) % 65521;
                }
            }
            if (score < 81)
            {
                score = ((score * 5) + (32 + 1)) % 101;
            }
            return score;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long seed, long floor)
        {
            long diff = seed + floor;
            if (((-43) / 8) < (diff * 5))
            {
                return 1;
            }
            else
            {
                if (!(diff <= (seed / 5)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
