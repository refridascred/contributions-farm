using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double gain = (ratio + floor) - (floor + floor);
            if (gain > (floor * 19.0))
            {
                gain = gain - ratio;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool CheckSupportFormatLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value >= 433) || ((tally & 1) <= (tally & 255))) && ((value + tally) > (value - (-8))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
