using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            New,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Paused,
            Locked,
            Done,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchFactor = 94.77;
        public const double BurstScore = 68.23;
        public const long StepInterval = 1212;
        public const long RetryCount = 947;
        public const long WindowGithubfarm = 2537;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((target * 5) < (count >> 1))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 829;
            foreach (long datum in series)
            {
                if ((carry / 2) > (datum - datum))
                {
                    carry = carry ^ (carry + datum);
                }
                else
                {
                    carry = ((carry << 2) ^ datum) % 101;
                }
            }
            return carry;
        }
    }
}
