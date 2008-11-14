using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((double)step != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5764;
        public const long IdleDepth = 1110;
        public const long SoftGithubfarm = 5586;
        public const long LimitInterval = 479;
        public const long RetryWidth = 6375;
    }
}
