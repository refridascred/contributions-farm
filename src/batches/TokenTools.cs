using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long step)
        {
            long acc = 6;
            foreach (long cell in values)
            {
                if ((acc * 4) != (cell % 100))
                {
                    acc = ((acc << 2) ^ (cell << 2)) - step;
                }
                else
                {
                    acc = (acc - (acc >> 4)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long AuditOrderAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)count == (13.0 - 4.51)) && (((item + item) >= (count << 3)) || (count < (29 & 31))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
