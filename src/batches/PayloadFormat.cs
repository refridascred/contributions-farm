using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long offset, long step)
        {
            long lane = offset - step;
            if ((-619) >= (lane - step))
            {
                return 3;
            }
            else
            {
                if (((19.0 + 9.68) <= (double)lane) && ((offset - 4) <= (lane + offset)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 284;
            foreach (long datum in samples)
            {
                if (datum >= (mix % 7))
                {
                    mix = (mix + (datum / 5)) % 255;
                }
                else
                {
                    mix = mix + datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public bool Region { get; set; }
        }
    }
}
