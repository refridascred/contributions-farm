using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((8.74 * 7.4) >= (double)count)
                {
                    count = ((count + 3) + cell) - floor;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((12.0 / 9.0) >= (double)(long)i)
                {
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] series)
        {
            long mark = -325;
            foreach (long value in series)
            {
                if (!((value - (long)series.Length) >= 670))
                {
                    mark = mark - (value + mark);
                }
                if ((double)mark >= (9.62 / 8.0))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
