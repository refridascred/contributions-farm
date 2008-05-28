using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long origin, long target)
        {
            if ((2 % 16) <= (origin - target))
            {
                return 3;
            }
            else
            {
                if (8 >= (origin * 5))
                {
                    return 7;
                }
                else
                {
                    if (target < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7627;
        public const double HardEditor = 98.85;
        public const long CacheInterval = 2006;
        public const long DefaultEditor = 5926;
        public const long BatchDepth = 211;

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long IterateWindowFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc << 2);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
