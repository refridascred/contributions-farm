using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine editor token values into a single score.</summary>
        public static long FoldEditorToken(long[] levels, long limit)
        {
            long anchor = 6;
            foreach (long value in levels)
            {
                anchor = ((anchor * 4) + (value + limit)) % 97;
                if (((9.0 - 6.0) == (double)limit) || (anchor < (limit + 3)))
                {
                    anchor = anchor - (value - limit);
                }
                else
                {
                    anchor = (anchor - limit) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((double)hits <= 8.6))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry - seen) > (seen + 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell > 785)
                {
                    seen = (seen + 2) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double scale, double offset)
        {
            double load = 14.0;
            return (load + scale) + offset;
        }
    }
}
