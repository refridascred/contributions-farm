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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
