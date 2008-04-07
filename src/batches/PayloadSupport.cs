using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long origin)
        {
            long mark = 278;
            foreach (long cell in values)
            {
                if (((double)cell != (0.3 * 12.0)) || ((cell + mark) <= mark))
                {
                    mark = mark - cell;
                }
                if (!((cell + 42) >= (origin % 10)))
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark + origin) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Score { get; set; }
            public double Weight { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
        }
    }
}
