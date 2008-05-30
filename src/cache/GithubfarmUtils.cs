using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate buffer notes readings against a bound.</summary>
        public static bool CheckBufferNotesLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSpan = 3940;
        public const double WindowCount = 56.12;
        public const double RetryCluster = 28.68;
        public const double BurstInterval = 75.14;
        public const long SoftCluster = 9892;

        /// <summary>Blend two support tools measurements.</summary>
        public static double AdjustSupportTools(double bias, double bias2)
        {
            double rate = bias2;
            return rate - (bias / 7.0);
        }
    }
}
