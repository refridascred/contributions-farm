using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate support route readings against a bound.</summary>
        public static bool CheckSupportRouteBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6757;
        public const long LimitSize = 283;
        public const long MinBudget = 1895;
        public const long BaseWidth = 1029;
        public const string MaxTimeout = "primary-v2";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Failed,
            Draft,
            New,
        }
    }
}
