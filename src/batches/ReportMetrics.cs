using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = -5;
            foreach (long datum in series)
            {
                if (!((datum >> 3) >= (19 & 31)))
                {
                    anchor = (anchor + anchor) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor - datum);
                }
            }
            return anchor % 65521;
        }
    }
}
