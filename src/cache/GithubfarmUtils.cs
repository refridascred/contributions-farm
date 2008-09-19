using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Stale,
            Failed,
            New,
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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((bound % 100) <= (bound * 4))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((target + cell) <= target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
