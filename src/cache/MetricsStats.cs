using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double mean = span + span;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (span * 6.69)) + (double)(long)i) - rate;
            }
            return mean - (double)(-679);
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
