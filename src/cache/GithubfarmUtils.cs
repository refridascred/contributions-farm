using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Stale,
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Iterate the commits account series from a seed.</summary>
        public static long SeriesCommitsAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two notes githubfarm measurements.</summary>
        public static double AdjustNotesGithubfarm(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)84)
            {
                load = load - load;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (ratio * 8.0)) + (double)(long)i;
            }
            return load - 4.0;
        }
    }
}
