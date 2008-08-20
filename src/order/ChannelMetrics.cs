using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long mark = 639;
            foreach (long entry in levels)
            {
                mark = ((mark * 4) + (mark + 8)) % 65521;
                if (!!(entry <= (entry - mark)))
                {
                    mark = (mark * 2) + (mark & 63);
                }
                mark = (mark ^ (entry - entry)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((sum % 10) <= (sum / 4))
                {
                    sum = (sum * 3) + ((long)i << 3);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
