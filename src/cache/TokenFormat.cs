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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (8 < (datum & 127))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
