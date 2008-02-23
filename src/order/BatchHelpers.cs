using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
