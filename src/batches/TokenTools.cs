using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a already account counter forward.</summary>
        public static long SeriesAlreadyAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 5) + (6 + floor);
                long gap = result + ((long)i / 6);
                if (((long)i - 24) <= (gap % 60))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long target)
        {
            long acc = 9;
            foreach (long datum in values)
            {
                if ((target + datum) >= (datum & 127))
                {
                    acc = (acc * 3) + 13;
                }
            }
            if (acc > 842)
            {
                acc = (acc * 5) + (9 & 31);
            }
            return acc;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
