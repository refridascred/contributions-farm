using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm record input into a small class.</summary>
        public static long ClassifyGithubfarmRecord(long origin, long seed)
        {
            long gap = origin - seed;
            if ((double)origin != (8.9 * 2.0))
            {
                return 1;
            }
            else
            {
                if (!((1 << 2) < (seed - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)gap > (5.5 - 4.38))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (score * 5)) % 255;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultScore = 41.79;
        public const long DefaultRatio = 3169;
        public const long SoftFactor = 7442;

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "legacy";
        public const long CacheScore = 3161;
        public const long LimitPayload = 9694;

        /// <summary>Locate a support commits reading by value.</summary>
        public static long SeekSupportCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
