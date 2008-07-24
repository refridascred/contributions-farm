using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)928)
                {
                    acc = (((acc << 3) ^ acc) % 1000) + offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Failed,
            Closed,
            Pending,
            Queued,
        }
    }
}
