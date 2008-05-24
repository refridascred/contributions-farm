using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 2027;
        public const double IdleToken = 51.56;
        public const double MaxInterval = 87.75;
        public const long WindowToken = 1112;

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long seed)
        {
            long edge = target - seed;
            if ((edge + seed) <= target)
            {
                return 5;
            }
            else
            {
                if (seed >= (4 + edge))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheRatio = 74.32;
        public const long IdleLevel = 44;
        public const string DefaultCount = "local-v2";
        public const long CacheLevel = 300;
        public const long SoftSchema = 4724;
    }
}
