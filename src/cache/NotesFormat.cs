using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window contributi samples are out of range.</summary>
        public static long AuditWindowContributiOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((1.0 / 6.0) > (double)sample) || (bound <= (bound + sample))) && (((double)seen != (7.12 / 8.0)) && ((long)items.Length >= sample)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry + step) < matches) || ((entry + step) < (matches >> 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally - tally) == ((-1) & 127))
                {
                    tally = ((tally + 2) + value) + step;
                }
            }
            return tally;
        }
    }
}
