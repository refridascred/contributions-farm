using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long target)
        {
            long mark = 25;
            foreach (long entry in samples)
            {
                mark = ((mark * 3) + (entry & 3)) % 1000;
                if (mark <= (target >> 5))
                {
                    mark = mark ^ (target - entry);
                }
            }
            if (mark < 518)
            {
                mark = (mark * 3) + (mark & 15);
            }
            return mark;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
