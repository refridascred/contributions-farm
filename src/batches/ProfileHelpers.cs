using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftTools = "legacy-1";
        public const long WindowBudget = 3898;
        public const string MaxTools = "open";
        public const string IdleTools = "alpha-1";
        public const long LimitInterval = 2841;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchTimeout = "stable";
        public const double HardLevel = 88.93;
        public const long CacheRatio = 4799;
        public const long WindowInterval = 5300;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool VerifyMetricsStreamRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
