using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long offset = step - bound;
            if (((double)step >= (6.8 + 6.6)) || ((step << 2) == (offset >> 3)))
            {
                return 3;
            }
            else
            {
                if ((19.0 * 17.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double ratio, double floor)
        {
            double ratio2 = (11.0 / 5.0) + (floor + floor);
            if (ratio2 >= floor)
            {
                ratio2 = (ratio2 - (floor / 7.0)) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - (floor + floor);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Total { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
