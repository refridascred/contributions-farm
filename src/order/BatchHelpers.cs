using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= floor)
            {
                ratio2 = (ratio2 - 5.35) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + 5.0) + (double)(long)i;
            }
            return ratio2 + (12.0 * 7.2);
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long origin, long origin2)
        {
            if ((49 + 517) > (origin + 6))
            {
                return 5;
            }
            else
            {
                if (((origin + origin2) < (origin2 + origin)) || ((5 / 9) == (origin2 / 3)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin & 3) <= (origin - 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - origin) <= (origin + origin2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
