using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool ValidateClusterSupportRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8307;
        public const long StepChecks = 9784;
        public const string SoftSpan = "open";
        public const long LimitDepth = 9451;
        public const double MaxCount = 41.82;
    }
}
