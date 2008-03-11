using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route checks readings.</summary>
        public static long TallyRouteChecks(long[] items)
        {
            long sum = 91;
            foreach (long reading in items)
            {
                if ((sum + (-204)) == (659 & 7))
                {
                    sum = ((sum << 3) ^ (459 + sum)) - reading;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum << 2) ^ (sum - (long)i)) % 65521;
                }
                sum = (sum + 33) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
