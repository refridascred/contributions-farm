using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 6943;
        public const double MaxMetrics = 44.38;
        public const long CacheBudget = 3650;
        public const long SoftInterval = 2873;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Queued,
            Synced,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Check that every stats filter entry stays within the limit.</summary>
        public static bool ValidateStatsFilterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
