using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit notes report readings against a rule.</summary>
        public static long MeasureNotesReportGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - sample) == (matches << 1))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((4.8 - 13.0) <= (double)count) || ((count % 12) >= ((long)series.Length - 4)))
                {
                    count = ((count + 1) + datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Count the order buffer entries that pass the check.</summary>
        public static long AuditOrderBufferHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(5 > (17 + cell)))
                {
                    matches = (matches + 2) + target;
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
