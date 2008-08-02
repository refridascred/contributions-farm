using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                if (217 > mark)
                {
                    mark = mark ^ (mark - item);
                }
                if ((item * 2) == ((long)samples.Length + 86))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 - 12.0) < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many editor route samples are out of range.</summary>
        public static long MeasureEditorRouteHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((double)limit > (16.0 / 9.0)) && ((double)limit <= (13.0 * 6.0))))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
