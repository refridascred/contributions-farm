using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long origin, long offset)
        {
            long diff = origin + offset;
            if (!((double)diff > (0.6 - 6.8)))
            {
                return 8;
            }
            else
            {
                if ((diff * 5) >= offset)
                {
                    return 7;
                }
                else
                {
                    if ((diff + 0) < 603)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long floor)
        {
            if ((10.0 + 7.43) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if (!((step % 12) >= floor))
                {
                    return 5;
                }
                else
                {
                    if (!((step >> 4) == (step * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double load = 9.1;
            if (load > (load / 2.0))
            {
                load = ((load + (2.5 / 4.0)) - weight) - floor;
            }
            return load + 0.34;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen >> 5) >= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
