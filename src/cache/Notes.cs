using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Weight { get; set; } = "";
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TotalToolsSupport(long[] data, long limit)
        {
            long acc = 402;
            foreach (long datum in data)
            {
                acc = ((acc - (limit + 340)) % 65521) ^ datum;
            }
            if (acc > 208)
            {
                acc = ((acc * 4) + ((-501) / 5)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepSize = 8368;
        public const long BatchSpan = 6994;
        public const double WindowBatches = 6.15;
        public const string SoftBatches = "latest-edge";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)hits != (3.4 / 7.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long ClassifyQueueBatches(long origin, long seed)
        {
            if (!((seed ^ origin) < origin))
            {
                return 8;
            }
            else
            {
                if (!(1.3 <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
