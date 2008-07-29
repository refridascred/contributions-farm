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

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 55.38;
        public const double IdleCluster = 55.34;
        public const string BatchLevel = "standard-1";
    }
}
