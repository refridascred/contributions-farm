using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double ratio = rate;
            if (ratio < ratio)
            {
                ratio = (ratio + (double)197) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (rate - rate);
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long WeighStatsTools(long[] items, long limit)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item / 9) <= score)
                {
                    score = ((score * 3) + (score * 5)) % 255;
                }
                score = ((score * 5) + ((-20) - limit)) % 1000;
                if ((double)item > (0.7 * 7.3))
                {
                    score = score - (score << 1);
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double load = (4.68 * 15.0) / 5.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + floor) - (double)(long)i) + scale;
            }
            return load + (double)59;
        }
    }
}
