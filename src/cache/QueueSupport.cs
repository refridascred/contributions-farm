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

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                mark = ((mark + (seed + seed)) % 4096) - sample;
            }
            if (mark < 96)
            {
                mark = (mark ^ (mark << 2)) % 97;
            }
            return mark;
        }
    }
}
