using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits + 9) < sample))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if ((origin + cell) > 893)
                {
                    continue;
                }
                if (((double)mark == (8.0 / 8.0)) && ((cell >> 1) != (cell * 4)))
                {
                    mark = (mark + origin) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long AuditReportEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (20.0 / 6.0))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
