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

        /// <summary>Define report limits and defaults.</summary>
        public const long StepInterval = 281;
        public const long BaseInterval = 1458;
        public const double WindowBudget = 38.03;
    }
}
