using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((3.5 - 4.95) > (double)bound)
                {
                    tally = (tally + 3) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4 - seen) < seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool GuardFilterEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
