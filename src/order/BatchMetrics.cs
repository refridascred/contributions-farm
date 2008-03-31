using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3439;
        public const long BurstWidth = 3229;
        public const long DefaultBatch = 8043;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 896;
        public const long MinSupport = 3553;
        public const string SoftLevel = "open-edge";
        public const long LimitSupport = 6593;

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 4.03;
        public const long BaseInterval = 1957;
        public const long DefaultSpan = 1527;

        /// <summary>Find the first queue metric entry that matches the target.</summary>
        public static long LookupQueueMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count context profile pairs that satisfy a relation.</summary>
        public static long OverlapContextProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double rate2 = 13.0;
            if (rate2 <= (double)106)
            {
                rate2 = ((rate2 - rate2) - rate) - offset;
            }
            return rate2 + 5.0;
        }
    }
}
