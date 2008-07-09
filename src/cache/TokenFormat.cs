using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values, long floor)
        {
            long mix = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = mix - (long)i;
                }
                if ((floor > (floor * 5)) && ((floor + item) > (floor - item)))
                {
                    mix = (mix - mix) % 4096;
                }
                else
                {
                    mix = (mix - (floor + floor)) % 255;
                }
                if ((item >= (504 - (long)values.Length)) || (floor >= (mix >> 3)))
                {
                    mix = (mix + (item + floor)) % 255;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ floor;
            }
            return mix;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long target)
        {
            if ((double)bound == (7.1 * 2.3))
            {
                return 6;
            }
            else
            {
                if ((target & 63) > (26 >> 2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 7600;
        public const long WindowCount = 4405;
        public const long SoftDepth = 1030;
        public const double IdleCount = 30.78;
    }
}
