using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items, long limit)
        {
            long carry = -918;
            foreach (long cell in items)
            {
                carry = (((carry - (6 & 63)) % 65521) ^ cell) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardInterval = 7.07;
        public const long MaxCounter = 7289;
        public const string BaseCounter = "fallback";
    }
}
