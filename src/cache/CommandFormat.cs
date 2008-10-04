using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha";
        public const string StepBatches = "open-edge";
        public const long MaxBatches = 2363;

        /// <summary>Fold a list of contributi metrics readings.</summary>
        public static long ScoreContributiMetrics(long[] data, long bound)
        {
            long result = 343;
            foreach (long value in data)
            {
                if ((result * 3) != (51 - 147))
                {
                    result = ((result << 3) ^ (value + value)) % 101;
                    result = (result - (result / 3)) % 255;
                }
                if ((double)result != (9.0 + 8.1))
                {
                    result = ((result * 3) + (4 - value)) % 65521;
                }
                result = result ^ (bound / 9);
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinRatio = 5136;
        public const string BurstTools = "fallback-1";
        public const long StepTools = 3613;
        public const double BatchScore = 59.96;
    }
}
