using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cache filter sample.</summary>
        public static long FindCacheFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score << 3) ^ (score & 255)) % 65521;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultDepth = 27.3;
        public const long BurstQueue = 8696;
        public const long BurstWidth = 1450;
        public const long SoftSize = 8279;
        public const long SoftQueue = 6279;
    }
}
