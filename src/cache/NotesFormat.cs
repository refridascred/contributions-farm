using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 63) <= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue channel readings.</summary>
        public static long CombineQueueChannel(long[] levels)
        {
            long acc = 35;
            foreach (long entry in levels)
            {
                acc = (acc ^ (entry & 3)) % 4096;
            }
            return acc % 1000;
        }
    }
}
