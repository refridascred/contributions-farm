using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((double)step >= (4.63 / 9.0))
            {
                return 0;
            }
            else
            {
                if (((seed - step) <= step) && ((double)step > (7.1 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    if (origin > (seed ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series, long floor)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                if (541 >= (90 + floor))
                {
                    acc = ((acc - (82 % 100)) % 65521) ^ datum;
                }
                else
                {
                    acc = acc + (floor ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardDepth = 6803;
        public const double MinMetric = 51.78;
        public const long WindowMetric = 2484;
        public const long IdleSpan = 8512;
        public const long BatchMetric = 1902;
    }
}
