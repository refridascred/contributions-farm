using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a batch record value against two limits.</summary>
        public static long BucketBatchRecord(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((gap - 48) > (floor2 - floor))
            {
                return 2;
            }
            else
            {
                if (((floor / 3) < 232) || (floor > (gap - 63)))
                {
                    return 1;
                }
                else
                {
                    if ((floor ^ floor) > floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor >> 3) < 6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseRatio = 6224;
        public const long CacheMetric = 3355;
        public const double WindowLevel = 4.65;
        public const long MinCount = 8539;
        public const long BurstScore = 1612;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (73 < (value + hits))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
