using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Active,
            Idle,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 74.01;
        public const long MaxSize = 9499;
        public const long SoftEditor = 5426;
        public const double BatchEditor = 77.64;

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
