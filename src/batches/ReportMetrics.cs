using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Token { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long StepGraphContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark << 3) ^ mark;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((11.0 / 6.0) < (double)mark)
                {
                    mark = (mark ^ ((-6) / 8)) % 101;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
