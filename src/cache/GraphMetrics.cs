using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double ratio2 = (3.1 / 7.0) + (double)304;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (((ratio2 - ratio2) + (double)(long)i) + ratio) - offset;
            }
            return ratio2 - 8.0;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double bias = weight;
            if (bias >= offset)
            {
                bias = bias - bias;
            }
            return bias + (weight - 6.0);
        }

        /// <summary>Check that every tools contributi entry stays within the limit.</summary>
        public static bool GuardToolsContributiBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((2.0 + 13.0) >= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
