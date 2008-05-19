using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 5714;
        public const long MaxProfile = 9551;
        public const string LimitProfile = "legacy-edge";
        public const string HardProfile = "latest-v2";
        public const double StepSpan = 18.89;
    }
}
