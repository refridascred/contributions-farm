using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Closed,
            New,
            Queued,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Pending,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if (!((anchor + entry) >= anchor))
                {
                    anchor = (anchor * 5) + (anchor & 15);
                }
            }
            return anchor;
        }

        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - matches) > (datum + 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Stale,
            Done,
        }
    }
}
