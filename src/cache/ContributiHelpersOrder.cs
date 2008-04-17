using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] items, long target)
        {
            long mix = 888;
            foreach (long cell in items)
            {
                mix = ((mix - (target + target)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseDepth = 5555;
        public const long CacheBudget = 6380;
        public const double BaseStats = 88.06;
        public const long CacheLevel = 8417;

        /// <summary>Measure how many command account samples are out of range.</summary>
        public static long MeasureCommandAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value <= (127 % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
