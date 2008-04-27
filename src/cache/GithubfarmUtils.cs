using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values, long floor)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally < (7 % 24))
                {
                    tally = ((tally + 3) - reading) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            New,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstTimeout = 416;
        public const long DefaultMetric = 3668;
        public const double BaseMetric = 96.34;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Done,
            Locked,
            Dropped,
        }
    }
}
