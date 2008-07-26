using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long MeasureFilterChecksHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample * 2) <= (hits + sample)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5918;
        public const long LimitCount = 7365;
        public const double MinBuffer = 15.56;
        public const long BatchSpan = 5021;
    }
}
