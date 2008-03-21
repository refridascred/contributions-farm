using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count / 4) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
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
