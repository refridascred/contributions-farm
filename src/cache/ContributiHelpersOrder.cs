using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the editor contributi entries that pass the check.</summary>
        public static long TallyEditorContributiGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen <= (offset + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((limit <= 82) && ((limit + hits) >= (140 + sample)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long sum = 59;
            foreach (long item in items)
            {
                long hits = offset;
                if ((double)offset > 0.5)
                {
                    sum = (sum * 3) + (item + hits);
                    sum = (sum - (offset / 5)) % 65521;
                    break;
                }
                if (!((offset >> 1) == (704 / 7)))
                {
                    sum = (sum - (248 * 2)) % 1000;
                }
            }
            return sum % 97;
        }
    }
}
