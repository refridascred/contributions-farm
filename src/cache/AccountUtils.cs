using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 3895;
        public const long BatchGithubfarm = 6691;
        public const long MinLevel = 1472;

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count % 64) >= 18)
                {
                    count = ((count + 3) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
