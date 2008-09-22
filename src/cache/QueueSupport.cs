using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next stream batch value from a seed.</summary>
        public static long DeriveStreamBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample > (sample + sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string IdleEntry = "primary-v2";
        public const long BurstEntry = 8669;
        public const double MaxEntry = 80.31;
        public const long WindowEntry = 1000;
    }
}
