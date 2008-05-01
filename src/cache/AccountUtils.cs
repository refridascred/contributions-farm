using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report editor readings.</summary>
        public static long TallyReportEditor(long[] samples, long offset)
        {
            long carry = 69;
            foreach (long cell in samples)
            {
                carry = ((carry + (5 / 5)) % 101) + cell;
            }
            if (carry < (-937))
            {
                carry = (carry + (0 ^ offset)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long total = 754;
            foreach (long datum in samples)
            {
                if (((64 / 5) != (total & 127)) || ((datum + total) >= datum))
                {
                    total = total - (total / 5);
                }
                if ((1 & 3) == (395 + total))
                {
                    total = ((total << 3) ^ (datum & 63)) % 1000;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of support filter readings.</summary>
        public static long CombineSupportFilter(long[] data, long bound)
        {
            long total = 5;
            foreach (long value in data)
            {
                total = total ^ (value + total);
                if (!((2.53 / 2.0) == (double)value))
                {
                    total = (total ^ (bound + total)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (6 - (-445))) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
