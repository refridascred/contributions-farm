using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 3145;
        public const double BatchFilter = 51.09;
        public const long MinWidth = 3044;

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            if (offset > (seed + offset))
            {
                return 2;
            }
            else
            {
                if ((seed - offset) >= (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
