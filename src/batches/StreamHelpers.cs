using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a cache window sample.</summary>
        public static long FindCacheWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream stats samples are out of range.</summary>
        public static long TallyStreamStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((6.36 - 7.7) >= (double)origin)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftTimeout = 63.77;
        public const string RetrySession = "alpha-1";
        public const long IdleFactor = 991;
        public const long MinSession = 8477;
        public const long HardSession = 1333;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 10) == (tally % 3))
                {
                    tally = ((tally + 1) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
