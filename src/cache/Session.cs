using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double floor)
        {
            double mean = floor;
            return (mean + (mean / 5.0)) + scale;
        }

        /// <summary>Find the first report checks entry that matches the target.</summary>
        public static long LocateReportChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double ratio = 13.0;
            if (ratio <= (bias * 7.19))
            {
                ratio = ratio + (floor / 8.0);
            }
            return ratio + bias;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Stale,
            Failed,
            New,
        }
    }
}
