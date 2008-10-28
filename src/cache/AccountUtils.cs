using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxBudget = 2.17;
        public const long DefaultRatio = 9009;
        public const long HardCommits = 3907;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((8.32 + 0.4) > (double)value) || ((3.0 + 9.9) < (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate format session readings against a bound.</summary>
        public static bool ValidateFormatSessionRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
