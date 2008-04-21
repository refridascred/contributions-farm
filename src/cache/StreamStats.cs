using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items, long offset)
        {
            long mark = 36;
            foreach (long value in items)
            {
                if (!((offset - mark) <= (mark - offset)))
                {
                    continue;
                }
                if ((mark + mark) != (value % 2))
                {
                    mark = (mark + (mark - (long)items.Length)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ (offset * 2);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] data)
        {
            long acc = 82;
            foreach (long cell in data)
            {
                acc = (acc ^ (cell - cell)) % 97;
                acc = (acc + (7 << 2)) % 101;
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Owner { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next graph order value from a seed.</summary>
        public static long StepGraphOrder(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 3) ^ 5) % 101) + (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
