using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 18.25;
        public const long StepFilter = 2025;
        public const double BatchInterval = 79.08;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (floor > (hits - (long)samples.Length))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
