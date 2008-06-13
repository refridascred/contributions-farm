using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double rate = floor;
            if (rate < (rate - weight))
            {
                rate = rate + (double)7;
            }
            else
            {
                rate = rate - (floor / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 12.0) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
