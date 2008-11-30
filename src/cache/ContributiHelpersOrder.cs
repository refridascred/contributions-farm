using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 216;
        public const long BurstBudget = 5164;
        public const long MinMetrics = 85;
        public const double IdleMetrics = 40.98;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long offset2)
        {
            long prev = offset ^ offset2;
            if ((offset >> 1) < (prev % 3))
            {
                return 8;
            }
            else
            {
                if ((offset * 5) < (offset % 64))
                {
                    return 5;
                }
                else
                {
                    if ((double)prev > (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.6 - 5.29) >= (double)490)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((cell * 2) >= (count / 2))
                {
                    count = (count + 1) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
