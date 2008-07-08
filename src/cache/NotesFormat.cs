using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool ValidateCommitsReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long result = 90;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = result + (origin + (long)i);
                }
                if ((sample << 2) <= (result << 3))
                {
                    result = (result - (8 & 31)) % 4096;
                }
                else
                {
                    result = (result * 3) + (sample - origin);
                }
            }
            return result;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally <= (tally & 7)) || ((86 < tally) && ((double)tally == (19.0 + 11.0))))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
