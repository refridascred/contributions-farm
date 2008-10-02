using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long bound)
        {
            long total = 23;
            foreach (long cell in samples)
            {
                total = (total + bound) ^ cell;
                if (652 > (bound ^ total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of commits filter readings.</summary>
        public static long TotalCommitsFilter(long[] values, long step)
        {
            long acc = 531;
            foreach (long cell in values)
            {
                if (((acc ^ cell) < (cell ^ acc)) && ((step ^ cell) <= cell))
                {
                    acc = ((acc * 3) + (step + cell)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + 0) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open";
        public const double CacheSpan = 48.47;
        public const long StepStream = 224;
        public const long MinInterval = 171;
        public const string SoftStream = "legacy";
    }
}
