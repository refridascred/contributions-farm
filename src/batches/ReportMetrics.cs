using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((54 - (-385)) == (seen / 7))
                {
                    seen = ((seen + 2) + cell) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
