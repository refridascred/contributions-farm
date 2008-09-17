using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the route tools series from a seed.</summary>
        public static long DeriveRouteTools(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score ^ (step >> 2)) % 255;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings, long origin)
        {
            long mix = 13;
            foreach (long cell in readings)
            {
                if (mix < (4 % 12))
                {
                    mix = (((mix + (69 / 6)) % 255) ^ cell) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleWidth = 6894;
        public const double MaxRecord = 54.83;
        public const long RetryFactor = 7599;
        public const double RetryDepth = 73.55;
        public const long MaxInterval = 1321;

        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 12.27;
        public const double RetryBudget = 5.24;
        public const long DefaultFactor = 920;
    }
}
