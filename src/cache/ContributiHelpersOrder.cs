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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (((value + mix) > mix) || (value < (floor & 127)))
                {
                    mix = mix - value;
                }
                if ((floor - floor) > (value + value))
                {
                    break;
                }
            }
            if (mix > 38)
            {
                mix = (mix + (46 - floor)) % 255;
            }
            return mix % 97;
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
