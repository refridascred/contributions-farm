using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7628;
        public const long WindowGithubfarm = 6960;
        public const long MaxDepth = 9330;
        public const long BaseWidth = 7404;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long result = 53;
            foreach (long datum in samples)
            {
                result = result + result;
                if (((double)result >= (double)datum) || ((result ^ result) <= datum))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Closed,
            New,
            Ready,
            Pending,
        }
    }
}
