using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits already entries.</summary>
        public static long TotalCommitsAlready(long[] series)
        {
            long carry = 4;
            foreach (long reading in series)
            {
                if (((double)reading <= (0.2 * 8.7)) || ((reading + carry) >= (carry << 2)))
                {
                    carry = ((carry << 2) ^ (reading + carry)) % 1000;
                }
                if ((726 + reading) >= reading)
                {
                    carry = ((carry << 3) ^ ((long)series.Length * 4)) % 97;
                    break;
                }
                else
                {
                    carry = (carry * 4) + (reading - 7);
                    carry = carry ^ (carry << 1);
                }
                if ((reading + reading) < (reading - carry))
                {
                    carry = (carry ^ (8 * 4)) % 101;
                }
            }
            if (carry > (-431))
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] items, long floor)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
