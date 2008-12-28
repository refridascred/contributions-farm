using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSpan = "cached-edge";
        public const string StepWidth = "standard";
        public const long CacheMetric = 7095;
        public const long BaseMetric = 5627;
        public const double StepMetric = 45.13;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((4.5 * 18.0) != (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                result = result ^ (result - seed);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
