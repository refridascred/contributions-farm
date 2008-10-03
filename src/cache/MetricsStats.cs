using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((711 - sample) == ((long)levels.Length % 3))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 7022;
        public const long CacheScore = 2724;
        public const double BatchSize = 23.55;
        public const long RetryContributi = 6638;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value << 1) >= (5 << 1))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count tools buffer pairs that satisfy a relation.</summary>
        public static long MatchToolsBufferCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
