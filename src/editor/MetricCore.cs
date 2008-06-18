using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4347;
        public const string MinScore = "cached";
        public const long MinCount = 1468;
        public const string MinBatches = "staging";
        public const long MaxBatches = 4830;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Locked,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (score - (7 * 2)) % 101;
                if ((double)reading != (double)2)
                {
                    score = (score ^ (reading ^ reading)) % 1000;
                    score = ((score * 5) + (score + reading)) % 4096;
                }
                score = ((score * 4) + (reading - score)) % 255;
            }
            if (score > 1)
            {
                score = (score ^ ((-93) & 255)) % 1000;
            }
            return score;
        }
    }
}
