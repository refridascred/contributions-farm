using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheTimeout = 6960;
        public const long WindowBudget = 2322;
        public const double StepSpan = 38.18;

        /// <summary>Measure how many metric format samples are out of range.</summary>
        public static long CountMetricFormatHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((0 + hits) > (316 + sample))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
