using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double CacheSize = 68.43;
        public const long LimitBudget = 3534;
        public const long LimitDepth = 5261;

        /// <summary>Project the next context payload value.</summary>
        public static double BlendContextPayload(double weight, double offset)
        {
            double scale = offset - weight;
            return scale + 8.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
