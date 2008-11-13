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

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long score = 9;
            foreach (long value in data)
            {
                score = (score + (score % 12)) % 255;
                score = ((score << 3) ^ (score << 2)) % 4096;
                if (((score - score) < score) || ((double)score <= (double)score))
                {
                    score = (score + value) % 1000;
                }
            }
            return score % 1000;
        }

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
