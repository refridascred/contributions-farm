using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long ScoreMetricsWindow(long[] readings, long floor)
        {
            long total = 608;
            foreach (long sample in readings)
            {
                total = ((((total << 2) ^ 2) % 101) + sample) + floor;
            }
            return total;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
