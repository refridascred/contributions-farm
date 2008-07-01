using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((limit << 2) == (hits + (-9)))
                {
                    hits = (hits + 1) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowDepth = 8822;
        public const string BatchEditor = "cached-edge";
        public const long BatchTimeout = 2437;
        public const long MaxTimeout = 8933;
        public const string HardBudget = "alpha";

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double rate = bias;
            return rate - (offset + offset);
        }
    }
}
