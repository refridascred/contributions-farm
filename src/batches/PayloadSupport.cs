using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long limit)
        {
            long carry = 843;
            foreach (long sample in levels)
            {
                if (!((sample - carry) <= (carry + sample)))
                {
                    carry = ((carry * 3) + (limit << 3)) % 101;
                }
                carry = (carry - 8) % 101;
            }
            return carry % 97;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long sum = 735;
            foreach (long entry in samples)
            {
                if ((entry - 8) >= (entry + entry))
                {
                    sum = ((sum << 3) ^ (383 + 25)) % 97;
                }
            }
            return sum;
        }
    }
}
