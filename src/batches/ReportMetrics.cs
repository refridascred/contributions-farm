using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((count << 1) <= (count << 3)) && (reading > count)) || (reading <= (floor & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            long cur = limit + bound;
            if ((cur % 3) != (71 ^ bound))
            {
                return 5;
            }
            else
            {
                if (((limit >> 3) < 614) || ((cur & 127) < (cur + limit)))
                {
                    return 1;
                }
                else
                {
                    if (cur >= (cur - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)cur <= 12.0)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2.7 - 2.0) != (double)anchor)
                {
                    anchor = ((anchor * 2) + (anchor - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
