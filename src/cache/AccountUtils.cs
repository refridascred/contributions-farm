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

        /// <summary>Audit command metrics readings against a rule.</summary>
        public static long CountCommandMetricsMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits + 31) < (hits + 1))
                {
                    hits = ((hits + 1) ^ item) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
