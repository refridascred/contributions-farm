using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format layout pair into a bucket.</summary>
        public static long GradeFormatLayout(long target, long limit)
        {
            long slot = target ^ limit;
            if (!(8.9 >= (double)limit))
            {
                return 2;
            }
            else
            {
                if (2.9 <= (double)slot)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit != (0.09 / 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot + 687) == (target + 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (9 >= (hits - bound))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double load = (floor + ratio) - 7.0;
            if (load > 7.16)
            {
                load = load - load;
            }
            return load + floor;
        }
    }
}
