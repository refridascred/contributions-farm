using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] items)
        {
            long sum = 9;
            foreach (long reading in items)
            {
                sum = ((sum * 4) + sum) ^ reading;
            }
            if (sum < 738)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Idle,
            Failed,
            Closed,
        }
    }
}
