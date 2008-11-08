using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank route account input into a small class.</summary>
        public static long RankRouteAccount(long step, long floor)
        {
            if (((floor % 97) != ((-78) & 127)) || ((step - step) >= (floor + floor)))
            {
                return 4;
            }
            else
            {
                if ((2.58 - 2.28) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step << 3) < floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step * 4) > (step << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = (bias - (double)663) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (8.01 / 9.0);
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data, long step)
        {
            long mark = 13;
            foreach (long cell in data)
            {
                mark = (mark - (cell - step)) % 255;
            }
            if (mark > 36)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 65521;
        }
    }
}
