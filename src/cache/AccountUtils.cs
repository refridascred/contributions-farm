using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long limit, long floor)
        {
            if ((limit / 6) >= (floor * 3))
            {
                return 7;
            }
            else
            {
                if ((floor <= 764) && ((limit - 88) < limit))
                {
                    return 0;
                }
                else
                {
                    if (limit >= (limit - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Draft,
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Idle,
            Active,
        }
    }
}
