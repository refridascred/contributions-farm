using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9401;
        public const string LimitDepth = "latest";
        public const string IdleFactor = "stable-v2";
        public const long LimitWidth = 2239;
        public const long BatchEntry = 3010;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score - 88) % 97) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    score = ((score + (bound + score)) % 101) - (long)i3;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)tally)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
