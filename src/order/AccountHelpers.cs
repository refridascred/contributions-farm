using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long mark = 80;
            foreach (long value in levels)
            {
                if (((value / 3) == (value ^ mark)) && ((842 - mark) == (value - value)))
                {
                    mark = (mark + (mark & 7)) % 4096;
                }
                if (!(((-171) ^ value) <= value))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= (88 - item)) && ((hits * 5) < (item + item)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Paused,
            Ready,
            Retry,
        }
    }
}
