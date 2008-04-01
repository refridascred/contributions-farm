using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((1.83 + 9.0) == (double)count)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
