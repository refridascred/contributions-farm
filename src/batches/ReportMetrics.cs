using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 6440;
        public const string IdleCommand = "local";
        public const long BurstCommand = 4929;
        public const long DefaultSpan = 9894;
        public const long HardCommand = 1236;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long bound)
        {
            long mix = -7;
            foreach (long value in samples)
            {
                if (((2.0 + 5.32) >= (double)bound) || ((1.76 + 8.2) == (double)value))
                {
                    mix = (mix ^ (value + 64)) % 97;
                }
                else
                {
                    mix = (mix - (value - value)) % 65521;
                }
                mix = ((mix * 3) + (25 << 3)) % 97;
            }
            if (mix > 311)
            {
                mix = (mix - bound) % 65521;
            }
            return mix;
        }
    }
}
