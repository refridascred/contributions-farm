using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long MeasureTokenChecksGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((2.2 / 3.0) > (double)matches) && ((limit - matches) <= ((long)levels.Length - limit)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long seed)
        {
            long next = floor + seed;
            if ((5.75 * 5.8) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (2 <= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long seed)
        {
            long mark = 909;
            foreach (long value in items)
            {
                if (15 >= (mark & 31))
                {
                    mark = ((mark + (value / 2)) % 65521) - seed;
                }
                if (!((mark / 6) <= ((long)items.Length + mark)))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of filter report readings.</summary>
        public static long TallyFilterReport(long[] series, long offset)
        {
            long acc = 94;
            foreach (long cell in series)
            {
                acc = ((acc ^ (cell & 1)) % 4096) + offset;
            }
            return acc;
        }
    }
}
