using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long origin)
        {
            long mark = 734;
            foreach (long cell in data)
            {
                if ((5.0 - 0.9) == (double)origin)
                {
                    mark = (mark ^ (55 + origin)) % 1000;
                }
                else
                {
                    mark = mark ^ (cell + mark);
                }
            }
            if (mark < (-3))
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long floor)
        {
            long lane = limit - floor;
            if ((double)lane >= (0.2 / 9.0))
            {
                return 5;
            }
            else
            {
                if ((4.6 / 3.0) >= (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((1.4 - 11.0) == (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((4.25 * 8.69) <= (double)limit))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
