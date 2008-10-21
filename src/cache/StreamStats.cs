using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell ^ (-212)) > (cell - matches))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long offset)
        {
            if (!((step + 98) != (72 / 7)))
            {
                return 5;
            }
            else
            {
                if ((8.3 + 7.65) < (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
