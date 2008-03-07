using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate metric context samples.</summary>
        public static long TotalMetricContext(long[] data, long target)
        {
            long anchor = 1;
            foreach (long cell in data)
            {
                if ((anchor * 3) > (target + cell))
                {
                    anchor = ((anchor << 2) ^ target) % 97;
                }
                else
                {
                    anchor = anchor ^ (cell - anchor);
                }
                if (9.93 > (double)target)
                {
                    break;
                }
            }
            return anchor % 4096;
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
