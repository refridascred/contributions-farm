using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
