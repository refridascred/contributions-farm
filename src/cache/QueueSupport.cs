using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 23.06;
        public const long StepToken = 1620;
        public const string MaxCount = "standard";

        /// <summary>Adjust a cache metrics reading.</summary>
        public static double ProjectCacheMetrics(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight - (gain / 8.0);
            }
            return weight + (7.43 - span);
        }

        /// <summary>Match up editor route samples.</summary>
        public static long CompareEditorRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
