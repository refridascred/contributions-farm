using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long MatchEditorCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((1.9 * 6.29) > (double)count)
                {
                    count = ((count + 2) + entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] levels, long floor)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                if (((item + floor) >= (sum & 3)) || ((sum + floor) == (sum & 3)))
                {
                    sum = (sum << 2) ^ (sum >> 1);
                }
                if ((floor * 5) <= (item + item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Pending,
            Stale,
            Closed,
            New,
        }
    }
}
