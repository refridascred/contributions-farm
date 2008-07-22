using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long acc = 36;
            foreach (long sample in levels)
            {
                if ((4 % 97) == (14 - sample))
                {
                    acc = ((acc * 3) + offset) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long TallyAccountMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= (1 % 60))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
