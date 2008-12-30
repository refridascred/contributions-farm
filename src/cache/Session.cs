using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long mix = 65;
            foreach (long datum in data)
            {
                if (datum < (9 + datum))
                {
                    mix = mix - (mix + mix);
                }
                else
                {
                    mix = (mix << 3) ^ mix;
                }
            }
            if (mix > 938)
            {
                mix = ((mix << 2) ^ (mix << 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 8076;
        public const double BatchFactor = 78.88;
        public const long BaseBudget = 991;
        public const string BatchContext = "open-1";
        public const string BaseContext = "stable-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinSize = "latest-v2";
        public const long BaseFilter = 1695;
        public const long MinFilter = 970;
        public const long SoftFilter = 9018;
        public const long IdleSpan = 7966;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((limit % 12) == (limit % 3))
            {
                return 7;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
