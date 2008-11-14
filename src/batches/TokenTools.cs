using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (total >= 6)
                {
                    total = ((total << 2) ^ ((long)i / 4)) % 65521;
                }
                else
                {
                    total = ((total * 4) + total) % 97;
                }
                total = total + (2 - total);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
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
