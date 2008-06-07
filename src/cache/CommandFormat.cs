using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally >> 3) < (entry - tally)) || ((9 % 2) > (entry * 4)))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxCount = 4781;
        public const double WindowReport = 42.69;
        public const long SoftReport = 2298;
        public const double LimitFactor = 35.9;
        public const double RetryFactor = 7.71;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstRatio = 9664;
        public const double SoftScore = 27.6;
        public const long BatchStats = 7058;
        public const string DefaultCount = "fallback";
    }
}
