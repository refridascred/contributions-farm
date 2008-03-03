using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
