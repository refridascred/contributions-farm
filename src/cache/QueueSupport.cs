using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 53.61;
        public const long HardTimeout = 4303;
        public const long CacheLevel = 2499;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 5) + ((-59) - bound)) % 97;
                mark = mark ^ ((long)i % 16);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit session token readings against a rule.</summary>
        public static long TallySessionTokenOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((double)99 >= (double)matches))
                {
                    matches = ((matches + 1) ^ datum) - seed;
                }
            }
            return matches;
        }
    }
}
