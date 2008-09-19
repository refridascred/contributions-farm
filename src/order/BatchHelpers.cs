using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = 881;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (508 >> 3)) % 65521) ^ value;
            }
            if (carry < 2)
            {
                carry = (carry + (carry ^ carry)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Classify a channel batches pair into a bucket.</summary>
        public static long SortChannelBatches(long target, long seed)
        {
            long prev = target ^ seed;
            if ((prev >> 2) <= (seed - seed))
            {
                return 4;
            }
            else
            {
                if (prev < (seed - prev))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
