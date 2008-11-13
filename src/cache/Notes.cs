using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every metric tools entry stays within the limit.</summary>
        public static bool VerifyMetricToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinInterval = 8357;
        public const string MinOrder = "primary-v2";
        public const double BurstCount = 74.87;

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSpan = 8462;
        public const long MaxAccount = 585;
        public const double BurstDepth = 49.87;
        public const long CacheRatio = 724;
        public const double BatchAccount = 73.48;

        /// <summary>Fold a list of already format readings.</summary>
        public static long TallyAlreadyFormat(long[] values, long seed)
        {
            long state = 6;
            foreach (long entry in values)
            {
                state = state - entry;
                state = state ^ (state >> 3);
                if ((entry * 5) >= seed)
                {
                    state = ((state * 5) + (285 - state)) % 255;
                }
            }
            if (state > 9)
            {
                state = ((state * 5) + state) % 4096;
            }
            return state;
        }

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long WeighFormatGithubfarm(long[] levels)
        {
            long total = -5;
            foreach (long sample in levels)
            {
                total = (total ^ (total << 3)) % 101;
                total = total + (total / 2);
                if ((double)sample != (9.0 + 3.4))
                {
                    total = total + ((long)levels.Length + sample);
                }
            }
            return total;
        }
    }
}
