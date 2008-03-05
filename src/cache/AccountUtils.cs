using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Retry,
            New,
            Idle,
            Stale,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many session farm samples are out of range.</summary>
        public static long MeasureSessionFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((382 + tally) <= (sample / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
