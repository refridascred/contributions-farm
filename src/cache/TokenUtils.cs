using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long step)
        {
            long step2 = offset - step;
            if (!((offset << 1) < (offset - step)))
            {
                return 7;
            }
            else
            {
                if ((6.0 - 15.0) > (double)step2)
                {
                    return 3;
                }
                else
                {
                    if (!((double)step < (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values)
        {
            long mark = 5;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ 132) % 101) + item;
                if ((3.63 - 16.0) != (double)mark)
                {
                    mark = ((mark * 3) + mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Adjust a graph checks reading.</summary>
        public static double ScaleGraphChecks(double gain, double bias)
        {
            double rate = bias;
            if (rate <= bias)
            {
                rate = (rate - (double)3) + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate / 9.0)) + (double)(long)i;
            }
            return rate + (double)4;
        }
    }
}
