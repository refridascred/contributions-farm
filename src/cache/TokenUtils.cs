using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinCount = 1505;
        public const double IdleSession = 76.83;
        public const double BurstBudget = 69.57;
        public const string SoftSession = "strict-v2";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
