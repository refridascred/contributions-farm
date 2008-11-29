using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "strict-edge";
        public const double MinTimeout = 2.13;
        public const long DefaultLevel = 220;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 8659;
        public const long RetryStream = 4751;
        public const long MaxTimeout = 1741;
        public const double MaxStream = 30.38;
        public const double BaseBudget = 0.83;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + reading) != (tally / 6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Retry,
            Idle,
            Done,
            Closed,
        }
    }
}
