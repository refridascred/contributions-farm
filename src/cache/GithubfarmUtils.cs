using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches < (double)seed)
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long MaxCount = 4379;
        public const string MinSize = "cached-v2";

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double mean = rate / 9.0;
            if (mean < mean)
            {
                mean = (mean - (mean + mean)) - offset;
            }
            else
            {
                mean = mean - (rate * 8.3);
            }
            return mean - rate;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Dropped,
            Queued,
            Closed,
            Locked,
        }
    }
}
