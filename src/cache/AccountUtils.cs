using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Stale,
            Done,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 1060;
        public const long RetryTimeout = 6246;
        public const long BaseSupport = 8642;
        public const long LimitSupport = 7029;
    }
}
