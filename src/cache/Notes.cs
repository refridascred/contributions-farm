using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double floor)
        {
            double bias2 = (bias + floor) * 5.3;
            return bias2 + (bias2 * 6.2);
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long bound)
        {
            long result = 7;
            foreach (long value in readings)
            {
                result = (((result * 4) + (bound ^ 51)) % 1000) + value;
            }
            return result % 97;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((target << 2) != (target & 127)) || (((item * 2) != (target + 240)) || (item >= (target % 2))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long RankCounterEntry(long limit, long target)
        {
            if (target >= (target * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) != (6 - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a metric entry value against two limits.</summary>
        public static long ClassifyMetricEntry(long step, long step2)
        {
            if ((double)step >= (2.0 - 4.0))
            {
                return 8;
            }
            else
            {
                if ((16.0 + 5.52) != (double)step)
                {
                    return 2;
                }
                else
                {
                    if (step > (807 - 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(step2 > (step2 * 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
