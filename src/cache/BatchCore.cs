using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((double)limit != (15.0 / 4.0)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Rank editor metric input into a small class.</summary>
        public static long SortEditorMetric(long step, long target)
        {
            long next = step ^ target;
            if ((273 <= (target & 15)) && (next > (step << 2)))
            {
                return 6;
            }
            else
            {
                if (9.9 < (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((next + 924) > (target << 3)) && (step <= (step + next)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches >> 1) == (matches / 3))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
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
