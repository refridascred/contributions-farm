using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i + origin) < (long)i) && (((long)i / 4) != (mark - mark)))
                {
                    mark = mark ^ (origin - origin);
                }
                if (((-82) / 6) >= origin)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item >> 4) <= (54 ^ count)) && ((step - count) > (-1))) && ((double)item >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BaseContext = "strict";
        public const string LimitContext = "cached-v2";
        public const long IdleDepth = 4722;

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 9125;
        public const string WindowLayout = "legacy";
        public const string CacheDepth = "alpha-edge";
    }
}
