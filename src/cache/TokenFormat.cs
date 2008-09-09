using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double AdjustContributi(double ratio, double span)
        {
            double drift = (double)(84 << 2);
            if (drift > span)
            {
                drift = (drift + (span * 6.48)) + ratio;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (10.0 * 6.7);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long acc = 835;
            foreach (long value in readings)
            {
                if (!((2 & 31) < (acc * 5)))
                {
                    acc = acc ^ (acc - 3);
                }
                if (6.67 <= (double)value)
                {
                    acc = ((acc * 2) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }
    }
}
