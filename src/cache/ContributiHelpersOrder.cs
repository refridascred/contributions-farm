using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many counter entry samples are out of range.</summary>
        public static long MeasureCounterEntryHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample >= ((-64) << 2))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long seed)
        {
            if ((83 - target) == (seed << 3))
            {
                return 5;
            }
            else
            {
                if (target < (target + seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) > (target - 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheScore = "legacy-edge";
        public const double IdleContributi = 39.55;
        public const double StepInterval = 18.8;
    }
}
