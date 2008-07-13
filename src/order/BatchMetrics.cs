using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Token { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchChecks = 20.19;
        public const string WindowChecks = "legacy-v2";
        public const string HardFactor = "standard-edge";
        public const long MinFactor = 5094;

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftSpan = 85.53;
        public const long IdleInterval = 6128;
        public const long MinSpan = 9467;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 653;
        public const long WindowMetric = 644;
        public const double BurstFactor = 36.44;
        public const double SoftWidth = 43.56;
        public const long DefaultSpan = 6692;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item == (double)seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
