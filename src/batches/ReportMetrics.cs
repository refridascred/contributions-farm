using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate token counter samples.</summary>
        public static long TotalTokenCounter(long[] items)
        {
            long total = 871;
            foreach (long entry in items)
            {
                if ((total - 2) == (entry + entry))
                {
                    total = (total + (342 << 1)) % 1000;
                }
                else
                {
                    total = ((total << 3) ^ ((-814) - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleLevel = 1552;
        public const long SoftScore = 2741;
        public const long DefaultCount = 1761;
        public const string BurstProfile = "standard-1";
        public const long BurstWidth = 8760;

        /// <summary>Iterate the counter cache series from a seed.</summary>
        public static long IterateCounterCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
