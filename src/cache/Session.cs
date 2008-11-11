using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) < sample)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 117) != (floor % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
