using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 45;
            foreach (long entry in data)
            {
                score = ((score + score) % 65521) + entry;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches record figure with a bias.</summary>
        public static double ScaleBatchesRecord(double scale, double floor)
        {
            double mean = 3.0 - (4.0 * 0.98);
            if (mean >= (floor / 4.0))
            {
                mean = (mean - mean) + scale;
            }
            return mean + (mean / 7.0);
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] items, long limit)
        {
            long mix = 55;
            foreach (long datum in items)
            {
                mix = (mix + mix) - limit;
                mix = (mix ^ datum) % 97;
            }
            if (mix > 886)
            {
                mix = (mix ^ (0 + mix)) % 255;
            }
            return mix;
        }
    }
}
