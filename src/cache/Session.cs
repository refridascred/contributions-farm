using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 94;
            foreach (long item in values)
            {
                if ((double)item < (0.1 - 5.0))
                {
                    carry = ((carry << 2) ^ (70 % 24)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
