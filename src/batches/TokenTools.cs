using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count >= (count - reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - seed) > ((long)levels.Length + 844))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRatio = 43.22;
        public const long BaseRecord = 981;
        public const double SoftRecord = 73.16;
        public const long MaxSpan = 7505;
        public const long StepRecord = 3378;
    }
}
