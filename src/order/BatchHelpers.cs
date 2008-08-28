using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((19.0 - 12.0) >= (double)floor) && ((seen / 5) <= (seen * 2)))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double scale = span;
            if (scale > 7.95)
            {
                scale = scale - ratio;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale / 8.0)) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
