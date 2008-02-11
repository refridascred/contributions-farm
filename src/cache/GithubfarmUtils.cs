using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Stale,
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double rate = 3.0;
            if (rate <= (double)665)
            {
                rate = ((rate + (rate / 4.0)) - ratio) - bias;
            }
            return rate - (double)0;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (bound > (bound + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
