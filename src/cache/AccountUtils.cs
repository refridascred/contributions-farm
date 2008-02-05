using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command cluster entry stays within the limit.</summary>
        public static bool ValidateCommandClusterLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels)
        {
            long carry = 8;
            foreach (long value in levels)
            {
                carry = (carry + value) % 97;
                carry = (carry * 4) + (carry - 6);
                if (carry >= value)
                {
                    carry = (carry * 2) + (value ^ value);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
