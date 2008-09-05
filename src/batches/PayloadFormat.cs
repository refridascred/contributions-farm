using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((494 + count) >= (sample - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxInterval = 3864;
        public const long WindowRatio = 7606;
        public const long SoftFilter = 7457;
        public const long IdleTimeout = 2064;
        public const long WindowFilter = 488;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
