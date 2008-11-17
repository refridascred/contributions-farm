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

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
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
