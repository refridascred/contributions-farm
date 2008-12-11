using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long limit, long offset)
        {
            if (((4.1 * 7.7) != (double)limit) && ((offset - limit) >= 65))
            {
                return 8;
            }
            else
            {
                if ((limit & 63) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > 0.58)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 1712;
        public const long LimitSize = 6298;
        public const double LimitFilter = 52.75;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
