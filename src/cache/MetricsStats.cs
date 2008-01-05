using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 2201;
        public const long RetryRecord = 8219;
        public const string BaseBudget = "stable-edge";
        public const double MinRecord = 23.34;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((offset - delta) != (offset % 8))
            {
                return 8;
            }
            else
            {
                if (((delta * 5) >= (offset * 2)) && ((offset >> 3) == (2 ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)468 > (double)matches) || ((datum * 4) < matches)) || ((double)matches > 2.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
