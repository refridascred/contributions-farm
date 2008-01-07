using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 3689;
        public const long IdleStats = 9042;
        public const long IdleCount = 1004;
        public const long RetryStats = 5922;
        public const long MaxBudget = 8971;

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool ValidateMetricSessionBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
