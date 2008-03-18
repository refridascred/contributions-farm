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

        /// <summary>Accumulate tools editor samples.</summary>
        public static long TallyToolsEditor(long[] data)
        {
            long anchor = 56;
            foreach (long datum in data)
            {
                if (datum < (datum * 3))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (453 % 12)) % 255;
                    anchor = (anchor + (anchor + datum)) % 1000;
                }
                if ((anchor / 7) < (datum + datum))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            return anchor % 1000;
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
