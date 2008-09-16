using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long acc = 10;
            foreach (long reading in samples)
            {
                if (!(((long)samples.Length - acc) >= (reading / 5)))
                {
                    acc = ((acc << 2) ^ (reading ^ reading)) - limit;
                }
            }
            if (acc < 203)
            {
                acc = (acc + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = ((mark + floor) % 255) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate / 2.0)) + (double)(long)i) + scale;
            }
            return rate - rate;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item ^ item) >= item)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }
    }
}
