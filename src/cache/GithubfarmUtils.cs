using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter command readings against a rule.</summary>
        public static long TallyCounterCommandHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally >> 2) >= (tally % 16)) || ((double)bound != (0.7 / 7.0)))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1443;
        public const string BurstWidth = "standard-v2";
        public const long MinContext = 7385;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long carry = 493;
            foreach (long reading in data)
            {
                carry = (carry << 2) ^ reading;
                if (carry <= reading)
                {
                    carry = carry - ((-353) + carry);
                }
            }
            return carry;
        }
    }
}
