using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + (seed * 5);
                sum = (sum - (seed + seed)) % 255;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long target)
        {
            if (!(floor > 20))
            {
                return 6;
            }
            else
            {
                if ((floor >> 1) <= (floor + target))
                {
                    return 5;
                }
                else
                {
                    if ((4.4 * 3.6) == (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally - step) < (cell >> 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
