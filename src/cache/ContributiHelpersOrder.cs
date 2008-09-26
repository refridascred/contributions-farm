using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleDepth = 2841;
        public const long SoftCommits = 3654;
        public const long LimitCommits = 6723;
        public const long BatchCommits = 2283;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
