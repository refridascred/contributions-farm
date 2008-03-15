using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits order input into a small class.</summary>
        public static long BucketCommitsOrder(long bound, long offset)
        {
            if ((568 < (offset - bound)) || ((double)offset == (double)bound))
            {
                return 6;
            }
            else
            {
                if (bound <= (offset * 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = (mark + (cell + 6)) % 255;
                if ((mark + mark) >= 78)
                {
                    continue;
                }
                if (!((935 - mark) < mark))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark + cell;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)bound != (10.0 * 0.2))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
