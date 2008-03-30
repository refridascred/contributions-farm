using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 5) + ((long)i - origin)) % 4096;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state + (origin % 8)) % 255) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Stale,
            Synced,
            New,
            Retry,
        }
    }
}
