using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes schema samples are out of range.</summary>
        public static long MeasureNotesSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)target < (double)774)
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((floor >> 2) == (cell / 8))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
