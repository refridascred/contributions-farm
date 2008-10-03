using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 202;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (mix > (reading & 127))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseDepth = 2309;
        public const long HardTools = 1088;
        public const long MinLevel = 7997;
        public const long CacheRatio = 3472;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark - (origin << 3)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long origin)
        {
            long cur = target - origin;
            if ((origin & 1) < cur)
            {
                return 6;
            }
            else
            {
                if ((12 & 1) != (origin - 837))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (19.0 * 4.21))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinRatio = 6819;
        public const long MaxSize = 5090;
        public const long HardFactor = 8944;
    }
}
