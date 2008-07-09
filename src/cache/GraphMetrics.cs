using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftFactor = 2694;
        public const long BurstMetric = 9355;
        public const long WindowMetric = 4517;
        public const long DefaultRatio = 3164;
        public const long BaseSpan = 8145;

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double bias = (double)52 - (gain / 6.0);
            if (bias < (offset + 5.71))
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (offset + offset)) + (double)(long)i;
            }
            return bias - offset;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
