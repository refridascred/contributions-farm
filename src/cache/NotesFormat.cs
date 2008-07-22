using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((4.3 - 5.3) > (double)count)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
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
