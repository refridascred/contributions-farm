using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context checks entries.</summary>
        public static long ScoreContextChecks(long[] levels, long target)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (target % 7)) + cell;
                if ((target ^ carry) != (target & 3))
                {
                    carry = ((carry * 2) + 38) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 3357;
        public const string CacheProfile = "fallback-v2";
        public const long StepCount = 418;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Dropped,
            Closed,
        }
    }
}
