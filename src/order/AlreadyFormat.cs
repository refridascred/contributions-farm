using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a window counter pair into a bucket.</summary>
        public static long RankWindowCounter(long bound, long offset)
        {
            long gap = bound + offset;
            if ((4.0 + 8.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)bound >= 5.42) || ((offset - 2) != (offset - gap)))
                {
                    return 2;
                }
                else
                {
                    if ((14.0 * 3.52) < (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 737;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (limit & 3)) % 97) ^ entry;
            }
            if (total > 87)
            {
                total = (total - (494 - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many account cache samples are out of range.</summary>
        public static long CountAccountCacheGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target <= (target * 4)) && ((14.0 * 15.0) <= (double)hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((-34) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
