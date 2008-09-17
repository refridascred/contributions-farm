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

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
