using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long step, long limit)
        {
            if (limit >= (limit - step))
            {
                return 6;
            }
            else
            {
                if ((limit / 4) >= step)
                {
                    return 3;
                }
                else
                {
                    if (((-973) % 7) <= (limit + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < limit)
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
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double ScaleLayoutStats(double scale, double floor)
        {
            double load = (double)58 / 8.0;
            if (load > (double)(-7))
            {
                load = (load + load) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (6.2 / 7.0)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if (mark >= (sample % 8))
                {
                    mark = mark - (mark >> 2);
                }
                if ((sample / 9) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell << 2) == (seen - floor))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
