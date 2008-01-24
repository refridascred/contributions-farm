using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long mix = 50;
            foreach (long datum in items)
            {
                mix = mix ^ (datum + origin);
                if (((long)items.Length / 3) < 86)
                {
                    break;
                }
            }
            return mix % 97;
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
