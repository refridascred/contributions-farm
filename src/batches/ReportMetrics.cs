using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Synced,
            Dropped,
            Idle,
            Active,
            New,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 9956;
        public const string BaseScore = "cached-edge";
        public const long IdleTimeout = 668;

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((765 << 3) >= (matches / 9))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
