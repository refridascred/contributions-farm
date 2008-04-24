using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of command metric entries.</summary>
        public static long ScoreCommandMetric(long[] series)
        {
            long carry = 1;
            foreach (long entry in series)
            {
                if ((double)carry > (0.31 + 2.0))
                {
                    carry = carry + entry;
                }
                if ((double)carry == (double)entry)
                {
                    break;
                }
            }
            if (carry > 3)
            {
                carry = carry + (carry % 24);
            }
            return carry;
        }

        /// <summary>Compare every pair of support batch readings.</summary>
        public static long PairSupportBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }
    }
}
