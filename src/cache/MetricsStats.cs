using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((matches % 5) <= (matches ^ 85)) && ((4.8 / 9.0) < (double)sample)) && ((double)matches >= (3.0 / 3.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
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
