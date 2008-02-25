using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long AuditEntryBufferMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen <= (datum % 8)) && ((seen ^ 52) != (datum - 399)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Synced,
            Queued,
            Ready,
        }
    }
}
