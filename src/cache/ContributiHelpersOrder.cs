using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8980;
        public const string CacheFactor = "fallback-1";
        public const long IdleSpan = 7024;
        public const double DefaultBudget = 37.79;

        /// <summary>Check that every route batches entry stays within the limit.</summary>
        public static bool CheckRouteBatchesBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
