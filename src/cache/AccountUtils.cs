using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
