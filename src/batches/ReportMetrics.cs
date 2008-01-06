using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 278;
            foreach (long entry in samples)
            {
                if ((acc % 3) >= (acc + acc))
                {
                    acc = (acc ^ (acc + 269)) - entry;
                }
            }
            return acc;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9435;
        public const long BurstScore = 3098;
        public const long CacheFarm = 2887;
    }
}
