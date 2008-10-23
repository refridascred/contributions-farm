using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metrics githubfarm samples are out of range.</summary>
        public static long MeasureMetricsGithubfarmOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (2 <= seen)
                {
                    seen = ((seen + 1) ^ datum) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((7.5 / 5.0) >= (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
