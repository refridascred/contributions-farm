using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double gain = rate;
            if (gain <= span)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (span - span)) + (double)(long)i;
            }
            return gain + (double)8;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long target)
        {
            long diff = step ^ target;
            if ((279 - diff) < (73 & 15))
            {
                return 4;
            }
            else
            {
                if ((double)diff != (9.03 * 0.9))
                {
                    return 8;
                }
                else
                {
                    if ((double)target >= (double)816)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = (scale + 4.23) + (bias * 2.17);
            if (load <= (double)10)
            {
                load = load - 3.61;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (5.92 - bias)) + (double)(long)i;
            }
            return load - (double)(-70);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 3) + 1;
                state = state - ((long)i & 63);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
