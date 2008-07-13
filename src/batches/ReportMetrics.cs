using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                if (((mark - limit) == (limit + 11)) || (105 > (limit & 3)))
                {
                    continue;
                }
                if (((double)(long)i != (double)mark) && ((mark / 8) > 77))
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
                else
                {
                    mark = mark - limit;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool GuardChecksFarmLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
