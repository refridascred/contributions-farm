using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 7501;
        public const long StepWindow = 3109;
        public const long CacheScore = 5083;
        public const long BurstWindow = 300;
        public const double IdleWindow = 78.64;

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long origin)
        {
            long mark = 73;
            foreach (long sample in readings)
            {
                if ((origin + 4) < (sample >> 2))
                {
                    mark = (mark * 5) + (-585);
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark < 374)
            {
                mark = mark ^ (814 << 3);
            }
            return mark % 97;
        }

        /// <summary>Locate a stats filter reading by value.</summary>
        public static long LookupStatsFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
