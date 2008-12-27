using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long CountRouteBufferMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((4.63 / 3.0) != (double)value)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((53 + matches) < (entry % 97)) || (entry >= (7 ^ entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm notes figure with a bias.</summary>
        public static double BlendGithubfarmNotes(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > 4.37)
            {
                scale2 = (scale2 - (double)7) + scale;
            }
            return scale2 - span;
        }
    }
}
