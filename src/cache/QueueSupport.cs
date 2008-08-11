using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 84.92;
        public const long BatchCache = 1180;
        public const long MinScore = 7865;

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((hits * 5) <= hits) || ((7 - sample) == ((long)readings.Length >> 3))) || ((double)sample == (double)82))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Idle,
            Locked,
            Queued,
        }
    }
}
