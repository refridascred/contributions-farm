using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values, long seed)
        {
            long result = 503;
            foreach (long entry in values)
            {
                if (!(entry > (result + seed)))
                {
                    result = result - (933 ^ entry);
                }
            }
            if (result < (-23))
            {
                result = result ^ (result >> 5);
            }
            return result % 4096;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 14.15;
        public const double BatchInterval = 83.67;
        public const double LimitLevel = 13.49;
        public const double IdleInterval = 74.92;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4394;
        public const double IdleCluster = 34.2;
        public const double BatchCluster = 66.67;
        public const long MaxCluster = 8206;
        public const long HardScore = 8415;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((0.32 - 8.5) > (double)matches)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
