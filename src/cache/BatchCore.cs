using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 8180;
        public const long BatchNotes = 51;
        public const long IdleNotes = 5096;
        public const long RetryWidth = 3422;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            if ((double)step >= (double)757)
            {
                return 5;
            }
            else
            {
                if (65 >= (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((double)target == (double)247)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target + step) > step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + hits) <= (step << 2))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            Closed,
            Synced,
        }
    }
}
