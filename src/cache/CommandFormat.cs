using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a counter report figure with a bias.</summary>
        public static double ProjectCounterReport(double gain, double span)
        {
            double bias = span;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias - (bias + 7.0)) + (double)(long)i) + gain;
            }
            return bias + (double)407;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] data)
        {
            long state = 2;
            foreach (long sample in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state << 3) ^ (state << 3)) ^ (long)i;
                }
                state = state ^ (1 + sample);
            }
            return state;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 4) + anchor) % 1000;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
