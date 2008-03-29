using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < (0 >> 1))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitTimeout = "staging-v2";
        public const long HardInterval = 3050;
        public const double HardCache = 86.91;
        public const double MaxCache = 0.98;
        public const long StepCache = 1669;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 9255;
        public const long MinBudget = 2959;
        public const double BurstFactor = 98.36;
        public const long MaxQueue = 9269;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((reading + 1) >= 11))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Dropped,
            Ready,
            Pending,
        }
    }
}
