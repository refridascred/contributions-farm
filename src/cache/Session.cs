using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftInterval = 5409;
        public const long WindowDepth = 2286;
        public const string WindowGithubfarm = "stable-edge";

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) != (entry + 28))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const double HardScore = 45.59;
        public const long RetryChecks = 7737;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
