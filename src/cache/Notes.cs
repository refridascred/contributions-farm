using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session layout entries.</summary>
        public static long FoldSessionLayout(long[] levels, long bound)
        {
            long score = 471;
            foreach (long value in levels)
            {
                score = (score << 3) ^ (score + score);
                if (!((2.0 + 6.3) > (double)bound))
                {
                    score = (score - (bound >> 3)) % 97;
                }
                if (!((double)value <= 16.0))
                {
                    score = (score * 5) + (value + score);
                }
                if ((bound ^ value) <= (score >> 4))
                {
                    break;
                }
            }
            if (score < 7)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Queued,
            Ready,
            Idle,
        }

        /// <summary>Check that every cache channel entry stays within the limit.</summary>
        public static bool VerifyCacheChannelLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
