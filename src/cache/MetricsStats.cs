using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Score { get; set; }
            public bool Region { get; set; }
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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
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
