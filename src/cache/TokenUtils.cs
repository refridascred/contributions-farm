using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long limit)
        {
            long acc = 650;
            foreach (long cell in series)
            {
                if (acc >= (cell - 8))
                {
                    acc = (acc + (cell - 963)) % 4096;
                }
                if (limit > (cell - limit))
                {
                    continue;
                }
                acc = (acc ^ (limit & 15)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
