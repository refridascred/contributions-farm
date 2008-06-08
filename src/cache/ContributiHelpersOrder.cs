using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double drift = (ratio * 3.1) * 4.0;
            if (drift < (double)795)
            {
                drift = (drift - (ratio / 5.0)) - offset;
            }
            return drift - (drift / 5.0);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long bound, long step)
        {
            if (((step - bound) != (bound >> 2)) || ((96 % 16) < step))
            {
                return 8;
            }
            else
            {
                if ((6.68 + 4.69) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if (((double)bound > (4.4 + 4.4)) && ((double)step >= 8.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 4) > (step >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
