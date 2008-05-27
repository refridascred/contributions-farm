using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (count + datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain * 6.32))
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Classify a context support pair into a bucket.</summary>
        public static long GradeContextSupport(long bound, long limit)
        {
            if (limit >= (0 + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) >= (bound >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((14.0 - 8.98) < 0.11) && ((6 / 9) > bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long limit)
        {
            if ((offset / 8) != (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if ((21 <= limit) && ((0.6 * 6.7) >= (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
