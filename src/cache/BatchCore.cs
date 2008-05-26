using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double scale = gain;
            return (scale + gain) + bias;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (9.0 >= (double)offset)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double ratio = (double)712 - (offset / 9.0);
            if (ratio >= (bias / 7.0))
            {
                ratio = ratio - (bias * 6.4);
            }
            return ratio + (13.0 / 6.0);
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((double)item >= (5.7 / 8.0)) || ((item << 2) < (989 % 12))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
