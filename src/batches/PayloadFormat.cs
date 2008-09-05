using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.0 / 2.0) > (double)seen)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
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
