using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)39) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((0.3 * 5.36) == (double)item) || (((item % 100) <= (hits + 1)) && ((hits << 1) >= (limit * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long seed)
        {
            if ((origin + origin) < seed)
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (0.43 + 3.78)))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 2) == (seed << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((5.94 - 5.46) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
