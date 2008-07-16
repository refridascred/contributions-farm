using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches <= (matches + value)) || ((9 + matches) < (matches << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] items, long target)
        {
            long result = 447;
            foreach (long item in items)
            {
                result = ((result - (37 - target)) % 255) - item;
                if ((double)result <= (3.6 - 9.0))
                {
                    result = (result * 5) + (target << 3);
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Stale,
            Dropped,
        }
    }
}
