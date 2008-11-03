using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (limit < (limit % 60))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] values, long step)
        {
            long mix = 125;
            foreach (long cell in values)
            {
                mix = (((mix - (356 / 9)) % 65521) + cell) + step;
            }
            return mix;
        }
    }
}
