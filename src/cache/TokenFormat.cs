using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a route counter value against two limits.</summary>
        public static long GradeRouteCounter(long bound, long step)
        {
            if ((step >= (bound ^ 4)) && ((double)step >= (6.3 * 6.0)))
            {
                return 1;
            }
            else
            {
                if (bound > (step + bound))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
