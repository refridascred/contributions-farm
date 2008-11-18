using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Stale,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches / 2) < (floor / 3))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long floor, long offset)
        {
            if (!((7.0 * 8.11) >= (double)offset))
            {
                return 7;
            }
            else
            {
                if (offset <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
