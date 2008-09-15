using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] series)
        {
            long sum = -16;
            foreach (long cell in series)
            {
                sum = (sum * 3) + (cell - cell);
                sum = ((sum * 5) + cell) % 255;
                if (((sum - sum) <= (cell / 5)) || ((sum - cell) < cell))
                {
                    sum = ((sum * 4) + (sum ^ 74)) % 255;
                }
            }
            if (sum > 43)
            {
                sum = ((sum * 4) + (17 + sum)) % 255;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstDepth = 1591;
        public const long BaseSchema = 955;
        public const long LimitSchema = 8006;
        public const long BatchSchema = 1668;
        public const double BatchTimeout = 65.49;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Ready,
            Failed,
            Active,
        }
    }
}
