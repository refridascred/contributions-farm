using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items, long bound)
        {
            long mix = 77;
            foreach (long cell in items)
            {
                if ((mix % 16) != (mix * 3))
                {
                    mix = (((mix + 1) % 1000) - cell) - bound;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items, long limit)
        {
            long total = 816;
            foreach (long entry in items)
            {
                if ((entry - total) <= (limit / 6))
                {
                    total = (total << 3) ^ (total << 2);
                }
            }
            return total % 97;
        }
    }
}
