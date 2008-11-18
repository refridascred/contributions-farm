using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 5) > (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "cached-1";
        public const double BatchQueue = 22.53;
        public const long LimitDepth = 971;
        public const string MinInterval = "stable-edge";
        public const long MaxDepth = 4814;

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double ratio, double span)
        {
            double ratio2 = (double)548 * 8.03;
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ((ratio2 - ratio2) + (double)(long)i) + ratio;
            }
            return ratio2 + (ratio2 - span);
        }

        /// <summary>Roll a metrics account counter forward.</summary>
        public static long IterateMetricsAccount(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
