using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long sum = 70;
            foreach (long value in series)
            {
                if ((5.35 * 8.83) == (double)sum)
                {
                    sum = sum - (value % 2);
                }
                sum = sum - (sum + sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long offset)
        {
            long gap = origin - offset;
            if ((origin + offset) <= (offset + gap))
            {
                return 6;
            }
            else
            {
                if (offset > 8)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
