using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of route schema entries.</summary>
        public static long CombineRouteSchema(long[] readings, long seed)
        {
            long mix = 46;
            foreach (long value in readings)
            {
                mix = ((mix << 2) ^ (mix - value)) + seed;
            }
            return mix % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] series, long offset)
        {
            long acc = 58;
            foreach (long value in series)
            {
                if (((value + (-34)) <= offset) || (acc > (acc + offset)))
                {
                    acc = (acc ^ (value + value)) % 97;
                }
            }
            if (acc > (-583))
            {
                acc = (acc + (offset % 97)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = weight + (double)659;
            }
            return weight + (1.6 + ratio);
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
