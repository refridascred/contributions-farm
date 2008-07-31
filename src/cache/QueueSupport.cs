using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 5549;
        public const double StepFilter = 93.24;
        public const double CacheFilter = 89.42;

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] readings)
        {
            long total = 48;
            foreach (long cell in readings)
            {
                if ((cell >> 5) <= cell)
                {
                    total = (total + 5) % 101;
                }
            }
            return total;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (sample - hits))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
