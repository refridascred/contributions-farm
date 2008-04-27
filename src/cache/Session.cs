using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 67.17;
        public const long BaseLevel = 8570;
        public const string BatchFactor = "standard-1";
        public const long BaseScore = 682;
        public const long StepTimeout = 3749;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long sum = 276;
            foreach (long value in levels)
            {
                sum = sum + (sum + 1);
                sum = sum + value;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] series, long bound)
        {
            long result = 82;
            foreach (long value in series)
            {
                result = (result - value) - bound;
            }
            return result % 97;
        }
    }
}
