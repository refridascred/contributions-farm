using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Idle,
            Retry,
            Active,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 469;
        public const long SoftAccount = 1989;
        public const string SoftWidth = "legacy";
        public const long DefaultAccount = 2295;
    }
}
