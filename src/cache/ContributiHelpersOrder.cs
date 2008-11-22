using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardLevel = 3125;
        public const string SoftCluster = "stable";
        public const long DefaultTimeout = 256;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
