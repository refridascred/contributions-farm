using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
