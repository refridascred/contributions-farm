using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine graph already values into a single score.</summary>
        public static long WeighGraphAlready(long[] levels)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = ((mark * 3) + (cell + mark)) % 101;
            }
            if (mark < 15)
            {
                mark = (mark ^ (6 - mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Count stream farm pairs that satisfy a relation.</summary>
        public static long CompareStreamFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
