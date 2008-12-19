using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics profile entries.</summary>
        public static long TallyMetricsProfile(long[] items)
        {
            long state = 384;
            foreach (long reading in items)
            {
                state = ((state + state) % 4096) - reading;
                state = ((state << 3) ^ state) % 255;
            }
            if (state < 5)
            {
                state = ((state * 4) + (state % 5)) % 4096;
            }
            return state;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 3) ^ (limit + carry);
                if (((long)i ^ carry) != (carry / 4))
                {
                    carry = (carry + ((long)i * 2)) % 4096;
                }
                else
                {
                    carry = (carry + 982) % 255;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Stale,
            Closed,
            Locked,
        }
    }
}
