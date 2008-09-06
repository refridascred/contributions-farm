using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate contributi stats readings against a bound.</summary>
        public static bool GuardContributiStatsLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 5633;
        public const double MaxCount = 25.25;
        public const long MaxDepth = 195;
        public const double HardStats = 73.57;
        public const string DefaultFactor = "local-v2";

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
