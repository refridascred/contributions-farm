using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long floor, long origin)
        {
            long step = floor ^ origin;
            if (!(step < (origin & 31)))
            {
                return 6;
            }
            else
            {
                if ((double)step != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 3) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (3.8 < (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a account order counter forward.</summary>
        public static long SeriesAccountOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values)
        {
            long result = 70;
            foreach (long item in values)
            {
                if (((result / 3) < (result - item)) || ((result & 15) == (item & 15)))
                {
                    result = result - (result / 9);
                }
            }
            return result;
        }
    }
}
