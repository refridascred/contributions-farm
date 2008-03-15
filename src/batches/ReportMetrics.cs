using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long origin, long origin2)
        {
            long gap = origin + origin2;
            if ((1 % 100) >= (origin2 % 64))
            {
                return 6;
            }
            else
            {
                if (origin > (98 & 63))
                {
                    return 2;
                }
                else
                {
                    if (gap < (gap << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm batch readings.</summary>
        public static long PairGithubfarmBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
