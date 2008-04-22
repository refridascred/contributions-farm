using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Dropped,
            Retry,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Pending,
            Done,
            Retry,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
