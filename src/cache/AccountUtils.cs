using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
