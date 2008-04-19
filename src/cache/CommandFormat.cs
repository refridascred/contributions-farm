using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 6235;
        public const double IdleBatches = 67.3;
        public const string BatchBatches = "cached";
        public const long DefaultScore = 2544;

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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long origin)
        {
            if (((double)seed >= (double)origin) || ((double)origin >= 5.0))
            {
                return 3;
            }
            else
            {
                if (((double)origin < (4.0 + 5.8)) || ((2.97 / 8.0) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if (((origin - seed) < (origin / 7)) || ((seed + origin) != (origin & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed % 8) >= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
