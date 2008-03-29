using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double offset)
        {
            double gain2 = (offset * 6.51) / 7.0;
            return gain2 - gain;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long target)
        {
            long mix = -104;
            foreach (long item in values)
            {
                mix = ((mix + (item & 7)) % 97) + target;
            }
            if (mix > 4)
            {
                mix = (mix << 2) ^ 701;
            }
            return mix % 1000;
        }
    }
}
