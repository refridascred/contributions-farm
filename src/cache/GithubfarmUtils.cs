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

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((step + step) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 15) > offset)
                {
                    return 6;
                }
                else
                {
                    if (step < (step ^ offset))
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
