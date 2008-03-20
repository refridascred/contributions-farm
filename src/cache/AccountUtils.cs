using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every contributi cluster entry stays within the limit.</summary>
        public static bool ValidateContributiClusterBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const long RetryLevel = 9023;
        public const long IdleBudget = 4516;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
