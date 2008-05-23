using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long mark = 1;
            foreach (long cell in values)
            {
                if ((double)cell == (15.0 / 3.0))
                {
                    mark = (mark - mark) + limit;
                }
            }
            if (mark > 9)
            {
                mark = (mark << 3) ^ (90 / 6);
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of buffer contributi entries.</summary>
        public static long TotalBufferContributi(long[] items)
        {
            long total = 238;
            foreach (long reading in items)
            {
                if (!((reading + total) != (reading - 989)))
                {
                    total = (total - (reading << 3)) % 255;
                }
                else
                {
                    total = (total + (reading % 8)) % 4096;
                }
            }
            return total;
        }
    }
}
