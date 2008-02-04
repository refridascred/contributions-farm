using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = 239;
            foreach (long item in items)
            {
                if (((long)items.Length & 3) >= item)
                {
                    result = ((result << 3) ^ item) % 4096;
                }
                else
                {
                    result = result - ((-7) - item);
                }
            }
            if (result < 168)
            {
                result = ((result << 3) ^ ((-27) + result)) % 255;
            }
            return result;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long offset)
        {
            long cur = target - offset;
            if ((target * 3) < (cur % 10))
            {
                return 8;
            }
            else
            {
                if (target >= (68 + 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Queued,
            Ready,
            Locked,
        }
    }
}
