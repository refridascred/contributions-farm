using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

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
