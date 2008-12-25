using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((66 & 1) < target)
                {
                    state = (state * 4) + (target + target);
                }
                else
                {
                    state = (state + reading) % 101;
                }
            }
            if (state < 36)
            {
                state = (state - target) % 255;
            }
            return state;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double ratio, double offset)
        {
            double weight = offset;
            if (weight < (offset / 9.0))
            {
                weight = weight - ratio;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - 6.0;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] series)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if (((state & 31) != (state % 3)) && (entry < (entry & 255)))
                {
                    state = state + state;
                }
                else
                {
                    state = (state + (entry + entry)) % 1000;
                }
            }
            if (state < (-7))
            {
                state = ((state * 5) + (state + state)) % 65521;
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double gain = (offset / 4.0) - offset;
            if (gain <= scale)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - (scale - scale);
            }
            return gain - (double)242;
        }
    }
}
