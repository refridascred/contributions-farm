using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] series, long target)
        {
            long carry = 7;
            foreach (long entry in series)
            {
                carry = carry ^ target;
                if (target < (carry * 4))
                {
                    carry = carry - (target + (long)series.Length);
                    continue;
                }
                if (!((entry + target) >= entry))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            if (carry < 568)
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
