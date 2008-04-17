using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "staging-edge";
        public const long MaxSpan = 7433;
        public const long SoftTools = 1639;
        public const long DefaultSize = 3229;
        public const string CacheTimeout = "legacy-edge";

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings)
        {
            long sum = 901;
            foreach (long sample in readings)
            {
                if (((double)sum <= (15.0 + 4.5)) && ((double)sum >= (double)7))
                {
                    sum = ((sum - 0) % 255) ^ sample;
                }
                if ((2.0 * 2.4) < (double)sum)
                {
                    sum = (sum << 3) ^ 32;
                }
            }
            if (sum > 831)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
