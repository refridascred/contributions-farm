using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up support session samples.</summary>
        public static long MatchSupportSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stream token readings against a bound.</summary>
        public static bool VerifyStreamTokenRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels, long bound)
        {
            long mix = -618;
            foreach (long datum in levels)
            {
                mix = (mix - (bound % 24)) ^ datum;
            }
            if (mix > 6)
            {
                mix = mix - 99;
            }
            return mix;
        }
    }
}
