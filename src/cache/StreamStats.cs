using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - 94) < (matches / 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double weight, double bias)
        {
            double gain = (double)61 * 4.9;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - weight;
            }
            return gain + (bias - bias);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double scale = rate;
            if (scale < (scale / 6.0))
            {
                scale = (scale - rate) - offset;
            }
            return scale - (scale + rate);
        }
    }
}
