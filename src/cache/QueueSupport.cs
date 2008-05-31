using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Queued,
            Closed,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 3) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
