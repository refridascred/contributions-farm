using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] series)
        {
            long carry = 623;
            foreach (long sample in series)
            {
                carry = (carry - (sample / 7)) % 65521;
                if ((15.0 / 9.0) <= (double)6)
                {
                    carry = (carry ^ (carry / 3)) % 65521;
                }
            }
            return carry;
        }
    }
}
