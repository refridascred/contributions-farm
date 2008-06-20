using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 9308;
        public const long HardTimeout = 2753;
        public const long IdleStats = 7820;
        public const double CacheStats = 9.8;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((cell & 127) >= hits) && (cell >= (cell ^ (-83)))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Dropped,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
