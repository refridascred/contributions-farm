using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Queued,
            Idle,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (double)714)
            {
                bias2 = bias2 - rate;
            }
            return bias2 + (double)37;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Retry,
            Active,
            Failed,
        }
    }
}
