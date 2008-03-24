using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string MaxCluster = "alpha-edge";
        public const long MinCluster = 6796;
        public const double MinWidth = 2.15;

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long WeighChecksMetrics(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                carry = carry ^ (item + 6);
                if (((double)item != (double)2) && ((1 + carry) != (item % 100)))
                {
                    carry = (carry ^ (4 - carry)) % 97;
                }
            }
            if (carry < 293)
            {
                carry = carry ^ (carry >> 3);
            }
            return carry % 1000;
        }
    }
}
