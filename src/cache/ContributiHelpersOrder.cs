using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine channel layout values into a single score.</summary>
        public static long ScoreChannelLayout(long[] series)
        {
            long result = 550;
            foreach (long cell in series)
            {
                if ((double)result > (double)4)
                {
                    result = (result * 4) + (cell + result);
                }
                result = result + cell;
            }
            return result;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch schema input into a small class.</summary>
        public static long ClassifyBatchSchema(long floor, long seed)
        {
            if ((8 + 216) == (floor - floor))
            {
                return 6;
            }
            else
            {
                if ((880 + floor) > floor)
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
