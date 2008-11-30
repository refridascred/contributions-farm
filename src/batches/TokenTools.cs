using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowLevel = "strict-v2";
        public const long RetryEntry = 6486;
        public const long BaseEntry = 3110;
        public const long HardBudget = 7050;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((9 + value) >= (value / 2)) || ((value - seen) >= (8 / 5)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
