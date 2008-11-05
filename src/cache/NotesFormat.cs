using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 95;
            foreach (long value in data)
            {
                if ((total * 5) == (total & 255))
                {
                    total = (total - (total & 127)) % 65521;
                }
                if (80 < (8 + value))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long CountStreamReportMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((double)hits == (8.0 + 18.0)) && ((offset + item) >= offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Idle,
            Draft,
        }
    }
}
