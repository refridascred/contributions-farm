using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 17;
            foreach (long entry in values)
            {
                mark = (mark - entry) % 255;
            }
            return mark;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long bound = offset + origin;
            if ((double)offset >= 4.3)
            {
                return 8;
            }
            else
            {
                if ((offset / 7) != (bound - offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound - origin) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a counter order counter forward.</summary>
        public static long IterateCounterOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
