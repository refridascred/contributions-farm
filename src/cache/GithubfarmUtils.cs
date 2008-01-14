using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryRatio = 31.45;
        public const long BaseInterval = 5497;
        public const long IdleCommand = 9737;

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
