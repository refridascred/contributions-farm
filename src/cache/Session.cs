using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            if ((14.0 <= (double)bound) || (seed >= bound))
            {
                return 8;
            }
            else
            {
                if ((bound <= (65 >> 2)) || ((double)bound >= (6.0 + 0.1)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)mark >= 2.0)
                {
                    mark = (mark ^ (30 << 3)) % 4096;
                    mark = mark ^ step;
                }
                if ((double)(long)i <= (double)step)
                {
                    mark = mark + step;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 15) <= (count << 1)) || (((cell / 2) <= (cell + cell)) && ((target ^ 4) == (target % 24))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
