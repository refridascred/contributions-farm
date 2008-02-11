using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
