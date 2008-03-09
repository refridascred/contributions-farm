using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchInterval = 21.73;
        public const long RetryScore = 3745;
        public const long IdleCluster = 5812;

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long step)
        {
            if (step > (step << 3))
            {
                return 6;
            }
            else
            {
                if ((step % 8) != (991 - step))
                {
                    return 2;
                }
                else
                {
                    if (((step << 1) < step) && ((limit + limit) != (limit - 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
