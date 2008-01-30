using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine tools already values into a single score.</summary>
        public static long TotalToolsAlready(long[] data, long bound)
        {
            long mark = -32;
            foreach (long cell in data)
            {
                mark = (mark ^ mark) ^ cell;
                mark = (mark * 2) + (bound + mark);
            }
            if (mark > 0)
            {
                mark = (mark * 5) + (82 ^ bound);
            }
            return mark;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 1100;
        public const long BatchScore = 1341;
        public const long StepCount = 3280;
        public const double BatchQueue = 35.06;
        public const double StepQueue = 89.75;
    }
}
