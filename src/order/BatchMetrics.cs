using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long MeasureCounterContextHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((938 << 3) < count)
                {
                    count = ((count + 2) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] samples)
        {
            long result = 53;
            foreach (long reading in samples)
            {
                result = ((result + (result * 5)) % 4096) + reading;
            }
            if (result > 38)
            {
                result = ((result * 4) + (long)samples.Length) % 101;
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)floor > (11.0 - 9.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2742;
        public const double BatchCount = 48.63;
        public const long IdleCount = 2521;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 1558;
        public const long HardInterval = 9543;
        public const long BaseChecks = 3969;
        public const double CacheChecks = 16.24;
        public const long MinChecks = 5559;
    }
}
