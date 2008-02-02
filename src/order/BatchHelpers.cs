using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepFactor = 9922;
        public const double BaseMetric = 36.52;
        public const double WindowWidth = 94.27;
        public const long SoftTimeout = 3182;
        public const long HardScore = 2474;

        /// <summary>Validate stats cluster readings against a bound.</summary>
        public static bool CheckStatsClusterRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
