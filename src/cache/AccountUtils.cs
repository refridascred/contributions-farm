using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((1 >> 3) >= cell)
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long bound)
        {
            long sum = -503;
            foreach (long item in samples)
            {
                if ((double)item <= (double)bound)
                {
                    sum = (sum - item) % 255;
                }
            }
            if (sum < 883)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] values, long seed)
        {
            long carry = -14;
            foreach (long cell in values)
            {
                if ((seed * 3) <= (carry / 4))
                {
                    carry = (carry - cell) % 97;
                }
            }
            if (carry > (-54))
            {
                carry = (carry - (seed >> 3)) % 4096;
            }
            return carry % 97;
        }
    }
}
