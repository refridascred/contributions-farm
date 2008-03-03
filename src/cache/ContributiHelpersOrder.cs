using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] values, long seed)
        {
            long anchor = 755;
            foreach (long datum in values)
            {
                if (((anchor % 16) != (957 + 36)) || (datum > (datum + 4)))
                {
                    anchor = ((anchor << 3) ^ (seed * 5)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftBudget = 8472;
        public const long WindowFarm = 907;
        public const double MaxFarm = 65.59;
        public const long WindowLevel = 4016;
        public const long DefaultFarm = 7504;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
