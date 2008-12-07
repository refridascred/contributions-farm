using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long origin)
        {
            long span = limit + origin;
            if ((7.1 * 0.39) > (double)span)
            {
                return 8;
            }
            else
            {
                if (origin <= (limit + span))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
