using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7878;
        public const long MinInterval = 5679;
        public const long BurstFactor = 5124;
        public const long RetrySpan = 8777;
        public const long StepScore = 4531;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 478;
            foreach (long sample in series)
            {
                if ((3.94 / 4.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc & 127)) + sample;
                }
            }
            if (acc < 495)
            {
                acc = (acc ^ (acc >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Stale,
            Locked,
            Done,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data)
        {
            long score = -203;
            foreach (long cell in data)
            {
                if (score > (score - cell))
                {
                    score = ((score * 4) + (63 - score)) % 65521;
                }
                else
                {
                    score = (score + score) % 255;
                }
            }
            if (score > 137)
            {
                score = (score + (score / 6)) % 4096;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 5481;
        public const long BurstInterval = 9302;
        public const long BaseProfile = 6016;
        public const long BurstProfile = 287;
        public const long StepProfile = 3675;
    }
}
