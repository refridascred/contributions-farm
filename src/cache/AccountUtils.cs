using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)seen != (1.71 + 18.0)) && (70 > (step << 3)))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch githubfarm samples are out of range.</summary>
        public static long CountBatchGithubfarmHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (step >= (5 - matches))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
