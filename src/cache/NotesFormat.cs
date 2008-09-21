using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            Draft,
            Locked,
            Paused,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) >= (sample + 9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i > 2.3)
                {
                    carry = (carry + (38 + limit)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
