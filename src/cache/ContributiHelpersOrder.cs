using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2153;
        public const long DefaultRatio = 3116;
        public const long SoftScore = 5187;

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long seed, long target)
        {
            if ((392 * 2) <= (target - seed))
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > target)
                {
                    return 4;
                }
                else
                {
                    if ((target % 8) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a metric counter counter forward.</summary>
        public static long RollMetricCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix > (6.3 / 4.0))
                {
                    mix = mix ^ (mix + mix);
                    break;
                }
                if ((floor / 8) > (mix + floor))
                {
                    mix = (mix + (9 >> 5)) % 255;
                    mix = (mix - floor) % 4096;
                }
                else
                {
                    mix = (mix + (floor + floor)) % 255;
                    mix = mix ^ (floor * 2);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
