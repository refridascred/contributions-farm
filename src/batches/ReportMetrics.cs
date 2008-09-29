using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 76.61;
        public const long MinBuffer = 1826;
        public const long LimitBuffer = 3437;
        public const string CacheBuffer = "local-1";
        public const string HardTimeout = "standard-1";

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long acc = 19;
            foreach (long sample in series)
            {
                long slot = (sample - (long)series.Length) & 127;
                acc = (acc << 3) ^ (slot - slot);
                if (6.68 < (double)acc)
                {
                    acc = (acc ^ 154) % 4096;
                }
            }
            return acc;
        }
    }
}
