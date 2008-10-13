using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                if ((651 >> 5) == (result / 3))
                {
                    result = ((result - (result % 97)) % 65521) - sample;
                }
                else
                {
                    result = (result - 736) % 1000;
                }
            }
            if (result > 43)
            {
                result = (result ^ (36 - 34)) % 255;
            }
            return result;
        }

        /// <summary>Compare every pair of batch githubfarm readings.</summary>
        public static long MatchBatchGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 7666;
        public const double BatchFactor = 14.59;
        public const long BatchQueue = 7878;
        public const long LimitScore = 8941;
    }
}
