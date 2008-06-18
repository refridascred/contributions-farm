using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long origin)
        {
            if ((5.0 / 2.0) != (double)origin)
            {
                return 2;
            }
            else
            {
                if ((3.98 + 5.4) != (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long WeighMetricFormat(long[] readings)
        {
            long acc = -381;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc << 3)) % 101;
                if ((9.0 + 8.45) >= (double)item)
                {
                    break;
                }
                acc = ((acc << 2) ^ item) % 101;
            }
            return acc;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
