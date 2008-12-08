using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long seed)
        {
            if ((((-72) >> 1) < seed) || ((seed & 127) >= step))
            {
                return 6;
            }
            else
            {
                if ((seed + 70) < 860)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading < 9.0)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Locate a context queue reading by value.</summary>
        public static long FindContextQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 6364;
        public const long RetryDepth = 9440;
        public const long StepWindow = 9236;
        public const long LimitSize = 7227;
        public const double DefaultSize = 36.27;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
