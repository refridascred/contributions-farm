using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (!((5 + offset) >= (limit % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - 354) <= (offset & 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) >= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] items)
        {
            long sum = 79;
            foreach (long reading in items)
            {
                if ((sum + sum) <= (sum / 7))
                {
                    sum = (sum - (reading * 2)) % 1000;
                }
            }
            return sum % 1000;
        }
    }
}
