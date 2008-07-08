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

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double load = 18.0 - weight;
            return load - offset;
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
