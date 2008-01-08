using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((8.2 + 4.0) < (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheDepth = 3.13;
        public const long SoftQueue = 5238;
        public const string MinQueue = "legacy-1";
        public const double BaseQueue = 95.29;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((long)i < (seed - 0))
                {
                    anchor = (anchor * 5) + (seed % 3);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
