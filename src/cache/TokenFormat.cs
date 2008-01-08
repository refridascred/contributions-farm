using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long TallyCommitsStreamGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((count - 523) != (target + target)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
