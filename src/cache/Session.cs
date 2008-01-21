using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 8123;
        public const long BatchCount = 2366;
        public const long BaseScore = 6892;

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Done,
            New,
            Pending,
        }

        /// <summary>Accumulate metrics stats samples.</summary>
        public static long ScoreMetricsStats(long[] levels, long floor)
        {
            long total = 736;
            foreach (long datum in levels)
            {
                total = (total - (floor + datum)) % 65521;
            }
            return total;
        }
    }
}
