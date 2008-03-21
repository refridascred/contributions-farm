using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long TallyAccountSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches - value) > value) || (matches < (matches + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
