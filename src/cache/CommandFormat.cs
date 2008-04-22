using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a tools stats counter forward.</summary>
        public static long SeriesToolsStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 4) + (floor >> 4)) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9978;
        public const string WindowRecord = "strict";
        public const double RetryCount = 98.29;

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 8.09;
        public const double LimitSupport = 13.19;
        public const string SoftSupport = "strict-edge";
        public const string StepSupport = "latest-1";
        public const long DefaultSupport = 9546;
    }
}
