using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Label { get; set; }
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry ^ seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
