using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank graph tools input into a small class.</summary>
        public static long SortGraphTools(long step, long limit)
        {
            long slot = step - limit;
            if (((slot + limit) > (limit + step)) || ((slot >> 4) < limit))
            {
                return 2;
            }
            else
            {
                if ((double)slot < (3.6 * 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (2.0 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((slot + 5) <= (limit & 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stream entry measurements.</summary>
        public static double BlendStreamEntry(double ratio, double bias)
        {
            double rate = bias;
            if (rate > (double)0)
            {
                rate = (rate + bias) - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (rate - bias);
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double rate = bias;
            if (rate < (rate * 1.0))
            {
                rate = (rate - bias) - ratio;
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate * 7.8)) - (double)(long)i;
            }
            return rate - 4.35;
        }
    }
}
