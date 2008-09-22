using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading & 7) > (420 & 7))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload report samples.</summary>
        public static long ScorePayloadReport(long[] samples, long origin)
        {
            long state = 32;
            foreach (long item in samples)
            {
                state = (state + origin) ^ item;
            }
            return state;
        }
    }
}
