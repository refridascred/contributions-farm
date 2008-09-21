using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long CountBatchesCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading >= (tally * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (matches * 5)))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] readings, long seed)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = acc + (item + seed);
                if (6.5 > (double)item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long step)
        {
            if ((double)step > (0.1 - 5.0))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if (bound > (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + bound) >= 227) && ((double)step < 8.94))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
