using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items, long offset)
        {
            long sum = 7;
            foreach (long datum in items)
            {
                if (datum < (0 / 6))
                {
                    sum = ((sum - datum) % 65521) - offset;
                }
                else
                {
                    sum = ((sum * 2) + (4 - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long ClassifyProfileBuffer(long step, long origin)
        {
            if ((9 % 24) >= (step / 8))
            {
                return 2;
            }
            else
            {
                if ((origin & 255) >= (origin - step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string DefaultLevel = "local-edge";
        public const long IdleSpan = 5800;
        public const long LimitContext = 4137;

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitDepth = 4960;
        public const long BurstCommits = 2641;
        public const double RetryFactor = 27.69;
    }
}
