using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9306;
        public const double LimitSize = 30.17;
        public const double RetryFormat = 67.76;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of metrics schema readings.</summary>
        public static long TallyMetricsSchema(long[] samples)
        {
            long carry = 825;
            foreach (long reading in samples)
            {
                if ((1.0 - 6.79) <= (double)carry)
                {
                    carry = ((carry * 5) + 639) % 65521;
                }
                else
                {
                    carry = carry + (reading >> 2);
                }
            }
            return carry;
        }
    }
}
