using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long carry = 48;
            foreach (long cell in samples)
            {
                if ((cell < (cell ^ carry)) && ((carry - carry) > (20 & 63)))
                {
                    carry = (carry - (cell / 7)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
