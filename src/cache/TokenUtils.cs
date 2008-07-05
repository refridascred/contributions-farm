using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultWidth = 8341;
        public const long SoftInterval = 8736;
        public const long CacheInterval = 7669;
        public const long MinEditor = 797;
        public const long MaxEditor = 5631;

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
