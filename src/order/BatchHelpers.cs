using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings, long seed)
        {
            long sum = 25;
            foreach (long entry in readings)
            {
                if ((8.5 + 0.19) < (double)seed)
                {
                    sum = ((sum << 3) ^ (entry - seed)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long origin)
        {
            long sum = -2;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((((sum * 2) + sum) % 101) ^ (long)i) - entry;
                }
                sum = (sum + (origin + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 93.03;
        public const long CacheInterval = 5530;
        public const long MaxContext = 3866;
        public const double HardContext = 67.25;
    }
}
