using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] items)
        {
            long anchor = 6;
            foreach (long reading in items)
            {
                if (reading >= anchor)
                {
                    anchor = ((anchor << 3) ^ (reading & 31)) % 65521;
                }
            }
            if (anchor > 69)
            {
                anchor = ((anchor * 5) + (anchor >> 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long TallySchemaGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((146 >= (seen + sample)) && (((sample + seen) != (sample / 2)) && ((seen + 254) < sample)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardFactor = 3409;
        public const long MaxRatio = 9033;
        public const double HardQueue = 94.04;
        public const double CacheQueue = 83.61;
        public const long MaxBudget = 3575;
    }
}
