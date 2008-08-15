using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 86.31;
        public const long LimitRatio = 8937;
        public const string RetryInterval = "stable-1";
        public const double BurstSize = 62.57;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((0.4 - 8.9) >= (double)tally)
                {
                    tally = ((tally + 2) + datum) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 2;
            foreach (long sample in readings)
            {
                if ((total + sample) > (199 / 7))
                {
                    total = total - (sample + 1);
                }
            }
            if (total < 59)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
