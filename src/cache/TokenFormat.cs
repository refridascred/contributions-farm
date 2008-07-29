using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 6730;
        public const long DefaultRecord = 1568;
        public const long HardDepth = 3970;
        public const long LimitRecord = 6119;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long bound)
        {
            long carry = 42;
            foreach (long cell in series)
            {
                if ((carry + bound) < bound)
                {
                    carry = ((carry * 4) + (carry ^ cell)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
