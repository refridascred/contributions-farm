using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] series, long offset)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if (((double)offset >= 8.5) || ((sum + sum) == (offset - offset)))
                {
                    sum = ((sum << 2) ^ (619 - offset)) % 4096;
                }
                else
                {
                    sum = sum - (entry ^ sum);
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (sum * 5)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Stale,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleDepth = 3546;
        public const double BaseRatio = 9.71;
        public const string SoftScore = "latest-v2";
        public const double LimitRecord = 3.29;
    }
}
