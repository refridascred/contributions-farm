using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long sum = 63;
            foreach (long entry in items)
            {
                if (((sum * 5) == (sum * 2)) && ((sum << 1) <= (entry + origin)))
                {
                    sum = ((sum * 5) + (origin & 31)) % 65521;
                }
            }
            if (sum > 67)
            {
                sum = (sum ^ (sum + 21)) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 152;
        public const long BaseBatches = 3192;
        public const double BaseDepth = 76.08;
        public const long SoftBatches = 6301;
    }
}
