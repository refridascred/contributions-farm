using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches <= (79 + 70))
                {
                    matches = ((matches + 1) ^ value) - floor;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metric editor reading.</summary>
        public static double AdjustMetricEditor(double scale, double bias)
        {
            double ratio = scale - 4.74;
            if (ratio <= (ratio * 8.2))
            {
                ratio = ratio - (double)441;
            }
            else
            {
                ratio = ratio + (double)(-30);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias + ratio)) - (double)(long)i;
            }
            return ratio - 5.22;
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long CountLayoutCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits <= (8 + sample)) && ((8 & 255) > sample)) && ((double)sample <= 5.2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
