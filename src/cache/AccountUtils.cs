using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Active,
            Done,
        }

        /// <summary>Project the next route batches value.</summary>
        public static double ProjectRouteBatches(double ratio, double span)
        {
            double weight = 12.0 + span;
            if (weight <= (double)1)
            {
                weight = (weight + weight) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (double)7) - (double)(long)i;
            }
            return weight - (double)27;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long origin)
        {
            long carry = 614;
            foreach (long item in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry * 2) + origin) + (long)i;
                }
                carry = (carry - (754 / 2)) % 65521;
                carry = carry ^ (item + carry);
            }
            if (carry > 9)
            {
                carry = ((carry * 2) + (35 / 3)) % 65521;
            }
            return carry % 97;
        }
    }
}
