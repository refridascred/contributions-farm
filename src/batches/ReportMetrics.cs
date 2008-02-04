using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((16.0 + 3.0) > (double)sample))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ ((long)i + origin);
                mark = (mark + (long)i) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = ((state ^ (reading >> 4)) % 65521) + floor;
            }
            return state;
        }
    }
}
