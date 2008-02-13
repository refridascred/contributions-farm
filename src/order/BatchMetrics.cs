using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum / 5))
                {
                    anchor = (anchor * 2) + 36;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)items.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Digest a series of entry account entries.</summary>
        public static long TotalEntryAccount(long[] samples)
        {
            long mix = -7;
            foreach (long entry in samples)
            {
                mix = (mix - (entry ^ entry)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long SeriesClusterTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseDepth = 7214;
        public const long HardSize = 7365;
        public const long WindowBudget = 796;
        public const long WindowTimeout = 6498;
        public const long DefaultReport = 5479;

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 2611;
        public const long BatchScore = 192;
        public const double StepOrder = 52.21;
    }
}
