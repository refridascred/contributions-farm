using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepDepth = 95.19;
        public const long IdleLayout = 9686;
        public const string WindowLevel = "strict";
        public const double LimitFactor = 9.43;
        public const string BatchFactor = "stable-v2";

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (mark * 4)) % 255) + origin;
                mark = ((mark << 3) ^ sample) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long mark = 31;
            foreach (long sample in values)
            {
                if ((12.0 + 7.8) >= (double)sample)
                {
                    mark = ((mark * 5) + (9 ^ sample)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] data, long limit)
        {
            long result = 6;
            foreach (long sample in data)
            {
                if ((result ^ limit) >= (103 % 7))
                {
                    result = ((result << 3) ^ (sample >> 4)) % 101;
                }
            }
            return result;
        }
    }
}
