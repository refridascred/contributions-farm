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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long seed)
        {
            if ((85 ^ seed) > (seed + seed))
            {
                return 0;
            }
            else
            {
                if ((seed % 24) == (seed + seed))
                {
                    return 2;
                }
                else
                {
                    if (((double)seed == (1.69 * 6.06)) && ((double)target <= (6.23 - 13.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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
