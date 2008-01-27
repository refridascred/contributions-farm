using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed + origin;
            if (!((origin + seed) < seed))
            {
                return 8;
            }
            else
            {
                if (!((168 ^ origin) >= cur))
                {
                    return 5;
                }
                else
                {
                    if ((cur <= (cur - cur)) && ((17.0 * 17.0) > (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((4.49 / 9.0) <= (double)floor) && ((seen & 255) == (floor ^ 2)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "stable-edge";
        public const double SoftBudget = 48.29;
        public const double MinQueue = 8.11;
        public const long RetryQueue = 5372;
    }
}
