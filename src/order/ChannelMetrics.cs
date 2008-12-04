using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (4.1 - 5.33))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels, long offset)
        {
            long anchor = 8;
            foreach (long item in levels)
            {
                anchor = ((anchor ^ item) % 4096) + offset;
                anchor = ((anchor * 5) + anchor) % 97;
            }
            return anchor;
        }
    }
}
