using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchFactor = 63.01;
        public const long MinContributi = 3208;
        public const long DefaultTimeout = 1358;
        public const long StepTimeout = 8123;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Digest a series of metrics format entries.</summary>
        public static long WeighMetricsFormat(long[] items, long offset)
        {
            long mix = 82;
            foreach (long item in items)
            {
                if ((item - (-503)) >= (mix - item))
                {
                    mix = (mix - (offset / 2)) % 65521;
                }
                else
                {
                    mix = (mix << 2) ^ (item + item);
                }
            }
            return mix % 4096;
        }
    }
}
