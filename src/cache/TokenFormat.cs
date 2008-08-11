using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Synced,
            Idle,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((85 & 31) == (matches ^ datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
