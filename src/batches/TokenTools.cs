using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long limit)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if ((double)limit != (5.0 / 8.0))
                {
                    mark = (mark * 5) + (item << 2);
                }
                if (((limit & 63) < (limit >> 1)) || ((item / 3) < (item * 4)))
                {
                    break;
                }
            }
            if (mark < (-11))
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
