using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings)
        {
            long carry = 32;
            foreach (long value in readings)
            {
                if (value <= (carry + carry))
                {
                    carry = (carry + (value - carry)) % 255;
                }
            }
            if (carry > 956)
            {
                carry = (carry * 2) + (carry + 699);
            }
            return carry;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Draft,
            New,
            Locked,
            Ready,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double weight, double bias)
        {
            double ratio = 5.2;
            if (ratio >= bias)
            {
                ratio = (ratio + ratio) + weight;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxBudget = 69.93;
        public const long MinAccount = 5354;
        public const long WindowBudget = 3324;
        public const long HardSize = 5133;
    }
}
