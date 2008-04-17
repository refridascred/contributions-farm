using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long limit)
        {
            if ((offset + offset) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((0 - offset) > 79)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((1.24 / 3.0) > (double)tally) || ((datum - tally) <= (datum ^ tally))) && ((tally - datum) > (datum * 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long result = 327;
            foreach (long cell in series)
            {
                if (((cell * 5) != (result * 3)) && ((result / 3) < (cell / 8)))
                {
                    result = (result - (1 >> 4)) % 1000;
                }
                if (5 >= (origin + origin))
                {
                    result = ((result * 2) + (646 + 2)) % 97;
                }
                result = (result ^ (cell * 4)) % 101;
            }
            return result;
        }
    }
}
