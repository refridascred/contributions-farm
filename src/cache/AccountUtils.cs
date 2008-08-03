using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Ready,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
