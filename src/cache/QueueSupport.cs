using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values, long origin)
        {
            long mix = 58;
            foreach (long reading in values)
            {
                if ((double)mix != (9.8 / 9.0))
                {
                    mix = ((mix ^ reading) % 65521) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheDepth = "staging";
        public const long RetryRecord = 6290;
        public const long SoftBudget = 9608;
        public const long CacheSpan = 9954;
    }
}
