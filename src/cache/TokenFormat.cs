using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardDepth = 3881;
        public const long CacheDepth = 9877;
        public const long SoftBatch = 2927;

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long DigestGithubfarmContext(long[] samples)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (963 + 23)) - item;
            }
            if (sum < 59)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
