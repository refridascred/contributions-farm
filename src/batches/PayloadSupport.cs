using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((6.47 / 8.0) < (double)value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
