using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            New,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 63) < (seed + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
