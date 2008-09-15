using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 49.59;
        public const double MinDepth = 47.16;
        public const long SoftQueue = 798;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleWidth = 8245;
        public const long BurstSize = 8079;
        public const string RetryNotes = "legacy-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryWidth = "fallback";
        public const string CacheTimeout = "legacy-edge";
        public const double WindowStats = 50.37;

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = bias2 - (double)4;
            if (bias3 < bias)
            {
                bias3 = bias3 - 4.07;
            }
            return bias3 - (double)4;
        }
    }
}
