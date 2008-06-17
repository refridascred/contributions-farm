using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Ready,
            Draft,
            New,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long floor, long target)
        {
            long offset = floor + target;
            if (!((offset / 7) > (floor % 60)))
            {
                return 3;
            }
            else
            {
                if (4.0 < (2.2 - 1.28))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) <= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
