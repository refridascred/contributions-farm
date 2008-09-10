using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long step, long offset)
        {
            long prev = step - offset;
            if ((5.94 * 1.0) != (double)prev)
            {
                return 4;
            }
            else
            {
                if (30 >= (offset + 588))
                {
                    return 7;
                }
                else
                {
                    if (!((offset ^ step) >= (step / 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long state = 828;
            foreach (long datum in series)
            {
                if (((datum + datum) < (datum - datum)) || ((datum - datum) >= (datum ^ datum)))
                {
                    state = (state ^ (datum >> 3)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) > reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
