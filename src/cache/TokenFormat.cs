using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data, long limit)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if (!((709 - carry) == (entry + limit)))
                {
                    carry = (carry - (limit * 3)) % 4096;
                }
                else
                {
                    carry = (carry - (7 - 16)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples)
        {
            long anchor = 44;
            foreach (long value in samples)
            {
                if (value <= (value ^ 15))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                if ((value + value) < anchor)
                {
                    anchor = (anchor - (anchor ^ value)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
