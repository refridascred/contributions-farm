using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            if ((step * 4) != (117 * 2))
            {
                return 5;
            }
            else
            {
                if ((8.05 / 4.0) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((17.0 < (double)step) && ((step + origin) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a metric record reading.</summary>
        public static double ScaleMetricRecord(double gain, double bias)
        {
            double mean = (double)(520 - 4);
            return ((mean + (double)7) + gain) + bias;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
