using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a route schema value against two limits.</summary>
        public static long ClassifyRouteSchema(long target, long bound)
        {
            if (bound < (12 - (-88)))
            {
                return 0;
            }
            else
            {
                if (!((target / 5) > (target + target)))
                {
                    return 8;
                }
                else
                {
                    if ((target ^ bound) >= (bound - 87))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (bias + 4.06))
            {
                scale2 = scale2 - (bias / 8.0);
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 4.0;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Active,
            Idle,
            Locked,
        }
    }
}
