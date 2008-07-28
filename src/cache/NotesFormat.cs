using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long MeasureMetricsFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((9 + item) <= item) && ((count + count) >= (count / 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long TallyGraphQueueGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (step >= (matches - step))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
