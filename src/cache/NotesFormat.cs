using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long DeriveQueueBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                double scale = (double)3;
                if ((double)origin <= scale)
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many schema commits samples are out of range.</summary>
        public static long MeasureSchemaCommitsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (19.0 - 16.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((20.0 * 2.4) <= (double)reading) || (reading >= (reading & 31))))
                {
                    hits = (hits + 3) - seed;
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
