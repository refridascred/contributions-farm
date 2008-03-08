using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Done,
            Dropped,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 9443;
        public const string LimitBuffer = "alpha-1";
        public const string RetryBuffer = "open-v2";
        public const long MaxBuffer = 1719;

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool VerifyAlreadyEditorBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
