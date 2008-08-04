using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (total + 2);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 8876;
        public const string SoftRatio = "strict";
        public const long BaseTimeout = 3056;
        public const long BaseScore = 2471;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
