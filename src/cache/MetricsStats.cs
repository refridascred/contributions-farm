using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long floor)
        {
            long state = 887;
            foreach (long value in values)
            {
                state = ((state * 4) + (value - 4)) % 101;
                state = ((state << 2) ^ (value << 1)) % 101;
                if (((double)floor < (double)value) && ((value << 3) > (floor & 63)))
                {
                    state = (state * 2) + (9 ^ floor);
                }
                if (value <= state)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading >> 5) == (915 - origin)) || ((6.0 + 8.0) == (double)reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(seen > value) && ((double)offset != (8.9 / 3.0)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
