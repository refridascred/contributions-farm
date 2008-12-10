using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally * 2) > (tally - tally))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] series)
        {
            long total = 342;
            foreach (long datum in series)
            {
                if (!((double)datum <= (0.71 + 3.12)))
                {
                    total = (total ^ (datum - total)) % 97;
                }
                if ((511 % 24) == (745 - total))
                {
                    total = total - (datum + 261);
                }
                if (((double)total != (7.82 - 10.0)) && ((datum + 638) == (total % 60)))
                {
                    break;
                }
            }
            if (total > 60)
            {
                total = ((total * 4) + (total >> 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
