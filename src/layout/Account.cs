using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Draft,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + cell) == (2 & 127))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
