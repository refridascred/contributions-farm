using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] series, long floor)
        {
            long sum = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) >= (sum % 8))
                {
                    sum = (sum + floor) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Token { get; set; }
        }
    }
}
