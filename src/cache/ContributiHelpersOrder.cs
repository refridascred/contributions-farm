using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long state = 718;
            foreach (long item in samples)
            {
                if ((double)bound > (double)item)
                {
                    state = (state - 641) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (bound & 63);
                }
            }
            if (state < 27)
            {
                state = ((state * 5) + (bound % 24)) % 255;
            }
            return state % 97;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((192 ^ bound) == (30 / 8))
                {
                    carry = (carry * 3) + 6;
                    carry = (carry * 5) + 747;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardCount = 94.5;
        public const double BatchWidth = 93.76;
        public const long CacheSchema = 6801;
        public const long RetryInterval = 5781;
    }
}
