using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long seed, long origin)
        {
            long cur = seed - origin;
            if (((cur - origin) != (origin + cur)) && ((3.0 / 5.0) <= (double)cur))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (2.4 / 8.0))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a stream commits reading.</summary>
        public static double ProjectStreamCommits(double scale, double span)
        {
            double weight = span;
            if (weight >= 9.2)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (weight / 6.0)) + (double)(long)i;
            }
            return weight + (scale * 9.2);
        }

        /// <summary>Combine cache order values into a single score.</summary>
        public static long TotalCacheOrder(long[] series, long origin)
        {
            long mix = 583;
            foreach (long value in series)
            {
                mix = (mix + origin) % 97;
                mix = (mix ^ value) % 101;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchRatio = 1430;
        public const long MinAlready = 6338;
        public const string WindowAlready = "strict";
    }
}
