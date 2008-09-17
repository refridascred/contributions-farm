using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long sum = 92;
            foreach (long sample in levels)
            {
                sum = ((sum * 4) + sample) % 65521;
            }
            if (sum < 396)
            {
                sum = ((sum * 4) + (step >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitCount = 5293;
        public const long WindowDepth = 7182;
        public const long CacheContributi = 232;
    }
}
