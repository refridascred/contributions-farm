using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate queue farm readings against a bound.</summary>
        public static bool CheckQueueFarmLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 5732;
        public const long IdleScore = 6547;
        public const double DefaultBudget = 60.42;
    }
}
