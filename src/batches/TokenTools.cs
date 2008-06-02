using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of buffer commits entries.</summary>
        public static long TotalBufferCommits(long[] values)
        {
            long sum = 73;
            foreach (long value in values)
            {
                if ((sum - sum) == (8 + value))
                {
                    sum = (sum + (value % 24)) % 4096;
                    sum = sum + (value % 3);
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum * 5) + (sum + 35)) + (long)i;
                }
                sum = (sum + (84 * 5)) % 255;
            }
            if (sum > 4)
            {
                sum = ((sum * 2) + (sum ^ sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7861;
        public const string CacheCount = "strict-v2";
        public const long WindowLevel = 3285;
        public const long BaseCache = 8186;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Draft,
            Stale,
            Closed,
        }
    }
}
