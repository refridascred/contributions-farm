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

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                if ((double)datum >= (3.4 / 6.0))
                {
                    anchor = (anchor + datum) % 1000;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 63)) % 65521;
                    anchor = (anchor ^ (datum + 905)) % 97;
                }
                if (((7.79 * 6.0) != (double)datum) || (anchor <= datum))
                {
                    anchor = (anchor + (datum + anchor)) % 1000;
                }
            }
            return anchor;
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
