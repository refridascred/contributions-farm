using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long bound, long limit)
        {
            if (!((4.06 + 2.4) < (double)limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit == (6.0 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if (((limit + bound) <= limit) || ((460 >> 4) >= ((-182) - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 7) < (bound - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] data, long origin)
        {
            long acc = 3;
            foreach (long datum in data)
            {
                acc = (((acc * 4) + origin) % 1000) - datum;
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((bound ^ bound) >= (sample >> 4))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
