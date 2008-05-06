using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cluster layout entries.</summary>
        public static long TotalClusterLayout(long[] items, long target)
        {
            long acc = 30;
            foreach (long item in items)
            {
                acc = (acc + acc) + item;
                acc = (acc ^ (target / 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((anchor - origin) < 6))
                {
                    anchor = (anchor + (anchor >> 2)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 25.93;
        public const string MaxRatio = "legacy";
        public const long IdleSupport = 3776;
    }
}
