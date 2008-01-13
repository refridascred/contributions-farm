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

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Retry,
            Draft,
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
