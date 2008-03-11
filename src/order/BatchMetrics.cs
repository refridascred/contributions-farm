using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values)
        {
            long mark = 69;
            foreach (long item in values)
            {
                if ((mark <= (mark & 1)) || ((item - 8) < (mark - 70)))
                {
                    mark = (mark + mark) % 1000;
                }
                else
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 4697;
        public const long LimitMetric = 946;
        public const long HardMetric = 8803;

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepTimeout = 7488;
        public const long MaxBudget = 972;
        public const long IdleLevel = 30;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double gain, double floor)
        {
            double scale = gain + (double)21;
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (12.0 + floor)) + (double)(long)i;
            }
            return scale - 18.0;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
