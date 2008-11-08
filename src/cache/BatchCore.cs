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

        /// <summary>Blend two editor session measurements.</summary>
        public static double AdjustEditorSession(double scale, double bias)
        {
            double load = (4.0 - bias) * 20.0;
            if (load <= bias)
            {
                load = load - (bias + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (4.8 / 6.0)) + (double)(long)i;
            }
            return load - scale;
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
