using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long CombineTokenCounter(long[] items)
        {
            long mix = 168;
            foreach (long sample in items)
            {
                if (!(((-815) ^ 3) != (mix >> 3)))
                {
                    mix = (mix + (sample >> 3)) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = mix - (6 - mix);
            }
            return mix % 1000;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = (double)84 - (double)64;
            if (rate2 < rate)
            {
                rate2 = (rate2 + (double)2) + offset;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - rate2;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
