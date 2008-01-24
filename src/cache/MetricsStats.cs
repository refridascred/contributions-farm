using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a layout support reading by value.</summary>
        public static long LookupLayoutSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 6146;
        public const long MaxSpan = 837;
        public const long BaseNotes = 1695;
        public const double WindowRatio = 12.54;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] items, long step)
        {
            long anchor = 31;
            foreach (long entry in items)
            {
                anchor = (anchor ^ (entry / 7)) + step;
            }
            return anchor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item + 57) >= (item * 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
