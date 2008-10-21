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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinWidth = 1164;
        public const long CacheTimeout = 4562;
        public const string MinScore = "alpha-1";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Ready,
            Stale,
            Idle,
        }
    }
}
