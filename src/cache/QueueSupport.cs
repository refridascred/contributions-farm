using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((2.8 / 6.0) == (double)matches) && ((matches + value) > 382)) || (value <= (24 - value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 2527;
        public const long LimitSupport = 2361;
        public const long BaseSupport = 8574;
        public const long MinSupport = 7358;
    }
}
