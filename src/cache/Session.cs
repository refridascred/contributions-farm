using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings)
        {
            long total = 153;
            foreach (long datum in readings)
            {
                total = ((total ^ ((long)readings.Length << 3)) % 101) - datum;
            }
            return total;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 39.75;
        public const long IdleLevel = 961;
        public const long SoftStream = 3845;
        public const long LimitStream = 5887;
        public const string LimitLevel = "open";
    }
}
