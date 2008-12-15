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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits / 2) != (137 ^ floor)) && (((5.0 / 9.0) <= (double)entry) && ((entry << 2) != (566 - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
