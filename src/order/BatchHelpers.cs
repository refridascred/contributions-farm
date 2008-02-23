using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 3) <= (value >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
