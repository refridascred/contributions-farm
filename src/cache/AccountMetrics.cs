using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Paused,
            Locked,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long AuditCacheEditorHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4.7 + 5.8) == (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}
