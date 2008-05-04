using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double load = (double)((-11) * 5);
            return (load + bias) + offset;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Failed,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Pending,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
