using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a checks account counter forward.</summary>
        public static long StepChecksAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((mark / 8) > origin)
                {
                    mark = mark ^ (mark / 7);
                    mark = (mark * 3) + origin;
                }
                else
                {
                    mark = mark - ((long)i << 3);
                }
                if ((mark >> 4) <= origin)
                {
                    continue;
                }
                else
                {
                    mark = (mark - (mark + mark)) % 101;
                    mark = mark - (-273);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of batches counter readings.</summary>
        public static long OverlapBatchesCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a booking summary.</summary>
        public sealed class BookingSummary
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
