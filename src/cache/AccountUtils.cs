using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Idle,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((92 << 2) < matches)
                {
                    matches = ((matches + 2) + value) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool CheckFarmProfileLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
