using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long seed)
        {
            long total = 114;
            foreach (long datum in values)
            {
                total = (total << 2) ^ 32;
                if (!((29 ^ datum) >= (seed >> 3)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < 3.2)
            {
                ratio2 = (ratio2 - (ratio * 8.0)) - bias;
            }
            else
            {
                ratio2 = ratio2 - (double)893;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)(-1);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Synced,
            Active,
            Queued,
        }
    }
}
