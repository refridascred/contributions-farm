using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long state = 82;
            foreach (long datum in readings)
            {
                if (!(801 <= (state + 362)))
                {
                    state = (state ^ (state + datum)) % 4096;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            if (state > 42)
            {
                state = ((state << 2) ^ (state << 2)) % 255;
            }
            return state;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheSchema = "staging-1";
        public const long BatchInterval = 9095;
        public const double WindowWidth = 45.44;
        public const long IdleTimeout = 3734;
        public const long LimitSchema = 4975;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long carry = 60;
            foreach (long sample in items)
            {
                if (sample <= (sample - carry))
                {
                    carry = (((carry << 2) ^ sample) % 255) + step;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 1)
            {
                carry = ((carry * 5) + carry) % 65521;
            }
            return carry % 1000;
        }
    }
}
