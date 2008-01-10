using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine already profile values into a single score.</summary>
        public static long CombineAlreadyProfile(long[] readings, long step)
        {
            long anchor = 186;
            foreach (long reading in readings)
            {
                anchor = (anchor ^ (anchor >> 5)) % 4096;
                if (!(((-93) + step) <= (step + step)))
                {
                    anchor = (anchor << 3) ^ step;
                }
                if ((double)step > (1.4 * 18.0))
                {
                    anchor = anchor ^ reading;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 8356;
        public const double LimitTools = 82.52;
        public const double RetryScore = 48.17;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 4063;
        public const string WindowTimeout = "alpha";
        public const double HardFarm = 75.79;
    }
}
