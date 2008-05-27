using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Label { get; set; }
            public bool Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Derive the next metrics report value from a seed.</summary>
        public static long StepMetricsReport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + ((long)i + 395)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
