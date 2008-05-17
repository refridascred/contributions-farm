using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Dropped,
            Locked,
            Paused,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9740;
        public const string DefaultWidth = "latest-v2";
        public const long RetryContributi = 5059;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ProjectGithubfarm(double gain, double floor)
        {
            double gain2 = (gain - 1.2) / 7.0;
            if (gain2 > (double)65)
            {
                gain2 = (gain2 + gain) + floor;
            }
            else
            {
                gain2 = gain2 - 9.82;
            }
            return gain2 - (5.0 + gain2);
        }
    }
}
