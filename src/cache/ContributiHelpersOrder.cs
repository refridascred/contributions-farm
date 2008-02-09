using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings, long step)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if ((double)step != (4.0 - 4.53))
                {
                    mark = (mark + 804) ^ cell;
                }
                else
                {
                    mark = (mark - (step + mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            long delta = offset + bound;
            if ((7.6 + 8.2) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound ^ bound) <= (4 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((offset & 31) > (delta ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
