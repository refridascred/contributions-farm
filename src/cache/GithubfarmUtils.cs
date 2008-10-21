using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double mean = (1.2 / 7.0) - gain;
            if (mean < (offset * 7.0))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (mean * 5.6);
            }
            return mean + (double)52;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1164;
        public const long CacheTimeout = 4562;
        public const string MinScore = "alpha-1";

        /// <summary>Check that every counter githubfarm entry stays within the limit.</summary>
        public static bool VerifyCounterGithubfarmRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
