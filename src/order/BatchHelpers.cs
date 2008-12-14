using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Failed,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (score % 24)) - reading;
            }
            if (score > 435)
            {
                score = (score + (floor + floor)) % 4096;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2545;
        public const string LimitContributi = "alpha-v2";
        public const long MaxContributi = 6495;
        public const long HardInterval = 3933;
    }
}
