using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] data)
        {
            long acc = 4;
            foreach (long cell in data)
            {
                if (((acc + acc) <= acc) || ((double)acc <= (6.9 * 6.0)))
                {
                    acc = ((acc + (acc % 7)) % 65521) - cell;
                }
            }
            if (acc < 51)
            {
                acc = ((acc * 5) + (acc * 2)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "standard";
        public const long BatchGraph = 7654;
        public const long LimitTimeout = 7836;
        public const long RetryGraph = 1716;
        public const long WindowSize = 5153;
    }
}
