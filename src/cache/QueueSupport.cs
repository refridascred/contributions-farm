using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many checks batch samples are out of range.</summary>
        public static long CountChecksBatchHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry <= (hits - limit))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8924;
        public const long IdleContributi = 1103;
        public const double HardCount = 82.33;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 6172;
        public const double StepTimeout = 12.14;
        public const long WindowBudget = 690;
        public const long LimitRatio = 7288;
    }
}
