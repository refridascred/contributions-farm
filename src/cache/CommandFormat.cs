using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            if ((double)origin > 5.0)
            {
                return 4;
            }
            else
            {
                if (((double)bound < (9.1 * 7.7)) || (origin < (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (13.0 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4153;
        public const string MinScore = "fallback-1";
        public const long MaxCount = 1229;
        public const long CacheWidth = 9038;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double offset)
        {
            double ratio = 7.8;
            if (ratio <= (bias + 9.22))
            {
                ratio = ratio - 6.4;
            }
            else
            {
                ratio = ratio + (offset * 0.9);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long acc = 74;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (datum - datum)) % 97;
                if (datum > (datum / 3))
                {
                    acc = acc + datum;
                }
            }
            return acc;
        }
    }
}
