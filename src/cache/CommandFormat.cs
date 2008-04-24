using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of already commits readings.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long score = 40;
            foreach (long sample in samples)
            {
                if ((score ^ score) >= (sample - sample))
                {
                    score = score ^ sample;
                }
                else
                {
                    score = (score << 3) ^ (sample % 3);
                }
            }
            return score;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long step2)
        {
            long gap = step ^ step2;
            if ((double)step == (double)gap)
            {
                return 0;
            }
            else
            {
                if ((double)gap > (4.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if (2 > step2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
