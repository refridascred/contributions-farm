using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Closed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Find the first session commits entry that matches the target.</summary>
        public static long SeekSessionCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
