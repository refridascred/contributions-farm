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

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
