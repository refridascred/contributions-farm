using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long limit)
        {
            long mark = 9;
            foreach (long entry in series)
            {
                mark = (mark + 864) % 65521;
                mark = ((mark * 2) + (mark * 4)) % 65521;
                if ((1.2 / 3.0) > (double)entry)
                {
                    mark = (mark + (limit >> 2)) % 255;
                }
                else
                {
                    mark = mark - (entry ^ limit);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
