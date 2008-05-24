using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Flag { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double scale = 8.13;
            if (scale <= bias)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (scale * 2.4);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((limit ^ limit) < sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] data, long limit)
        {
            long mix = 708;
            foreach (long entry in data)
            {
                if (((mix - mix) > (mix ^ entry)) && ((limit << 3) >= limit))
                {
                    mix = mix ^ entry;
                }
            }
            if (mix < 683)
            {
                mix = (mix << 2) ^ (62 - limit);
            }
            return mix;
        }
    }
}
