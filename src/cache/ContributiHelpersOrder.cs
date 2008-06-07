using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            if ((seed % 16) > (target - 25))
            {
                return 6;
            }
            else
            {
                if (1.31 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next metrics record value.</summary>
        public static double ScaleMetricsRecord(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > bias)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale + (double)74;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Closed,
            Draft,
            Locked,
        }
    }
}
