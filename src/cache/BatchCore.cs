using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double weight = (double)(43 - 89);
            if (weight <= (double)15)
            {
                weight = weight + gain;
            }
            return weight - bias;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data)
        {
            long mark = -527;
            foreach (long entry in data)
            {
                if (!((double)mark != (6.66 / 9.0)))
                {
                    mark = (mark << 3) ^ (mark + entry);
                }
                if ((entry - entry) > (entry & 31))
                {
                    mark = (mark - (mark << 1)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + (long)i) % 101;
                anchor = (anchor << 3) ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
