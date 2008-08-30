using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long mix = 1;
            foreach (long item in values)
            {
                mix = (mix ^ (mix + item)) % 97;
                if ((item ^ 819) != (6 - item))
                {
                    mix = (mix ^ (seed + item)) % 255;
                    break;
                }
                if (((mix - seed) >= (item - item)) && ((mix << 2) > (seed % 2)))
                {
                    mix = mix ^ (mix % 2);
                }
            }
            if (mix > 4)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long total = 4;
            foreach (long value in levels)
            {
                total = ((total * 2) + (limit - value)) % 101;
                total = (total + 21) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 1888;
        public const long BatchChecks = 895;
        public const double DefaultDepth = 61.83;
        public const long BatchTimeout = 1766;
    }
}
