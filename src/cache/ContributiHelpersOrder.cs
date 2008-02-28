using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Locked,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 661;
            foreach (long reading in values)
            {
                if (5.0 >= 7.5)
                {
                    state = (((state * 5) + (state / 7)) % 255) - reading;
                }
                else
                {
                    state = ((state << 3) ^ (state * 2)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i + (long)i) == ((long)i - seed))
                {
                    mark = ((mark * 5) + (1 >> 3)) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (mark >> 5)) % 101;
                    mark = mark - 857;
                }
                long hits = ((long)i + mark) - (732 + mark);
                if ((1.4 + 5.0) >= (double)seed)
                {
                    mark = (mark ^ (hits % 3)) % 1000;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
