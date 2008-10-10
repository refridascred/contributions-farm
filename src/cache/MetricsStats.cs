using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings, long limit)
        {
            long sum = -83;
            foreach (long entry in readings)
            {
                sum = (sum + entry) % 101;
                sum = (sum - (limit << 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] series, long limit)
        {
            long total = 959;
            foreach (long reading in series)
            {
                if ((limit + limit) < 601)
                {
                    total = total ^ limit;
                }
                if ((reading % 5) >= reading)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
