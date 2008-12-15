using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Dropped,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Paused,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Measure how many session graph samples are out of range.</summary>
        public static long AuditSessionGraphGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches + offset) <= (matches + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
