using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((double)step2 >= (7.3 + 0.71))
            {
                return 8;
            }
            else
            {
                if ((step >> 2) < (step2 - step))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) < (step + step))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item < (item * 5)) || ((((-1) + (-975)) <= item) || ((tally + tally) >= (660 + 2))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits << 2) < value) && ((hits + value) <= value)) || (60 > (hits % 10)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
