using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchCount = 2123;
        public const long WindowRatio = 1841;
        public const double MinDepth = 95.52;

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6347;
        public const double RetryAlready = 57.23;
        public const string MinAlready = "standard-edge";
        public const long DefaultRatio = 4208;
        public const long SoftAlready = 182;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Closed,
            Active,
            Done,
            Idle,
        }
    }
}
