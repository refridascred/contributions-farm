using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every route filter entry stays within the limit.</summary>
        public static bool ValidateRouteFilterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryScore = 25.33;
        public const long DefaultTimeout = 3099;
        public const long LimitCommits = 846;
        public const long MaxInterval = 7550;
        public const double BatchCommits = 21.02;

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + value) % 65521;
                if ((seed + 79) < (61 * 2))
                {
                    sum = (sum ^ 2) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum * 4) + ((long)levels.Length / 9);
            }
            return sum;
        }
    }
}
