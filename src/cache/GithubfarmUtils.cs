using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((sample > (count * 3)) || ((count << 2) != (sample + count))) || ((count * 5) < 378))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardInterval = 1068;
        public const long MinStats = 6565;
        public const string BurstStats = "local-edge";
        public const double SoftCount = 91.97;
    }
}
