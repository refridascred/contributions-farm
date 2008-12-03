using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 9652;
        public const double CacheScore = 42.54;
        public const long StepSpan = 7147;

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long MeasureFormatContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(datum <= (3 * 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultLevel = 4958;
        public const long RetryWindow = 2817;
        public const double LimitRatio = 79.59;
        public const string MaxWindow = "stable-edge";
    }
}
