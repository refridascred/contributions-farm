using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of tools notes readings.</summary>
        public static long OverlapToolsNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a entry report sample.</summary>
        public static long LookupEntryReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch entry samples.</summary>
        public static long CombineBatchEntry(long[] readings, long target)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = ((result + item) % 255) + target;
            }
            return result % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)step == (1.0 / 2.0))
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
