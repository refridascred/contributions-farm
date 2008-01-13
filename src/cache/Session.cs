using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] series, long floor)
        {
            long state = 718;
            foreach (long entry in series)
            {
                if (state < (entry + entry))
                {
                    state = (state ^ (4 + entry)) % 101;
                    state = state - entry;
                }
                if ((4.4 * 1.7) < (double)floor)
                {
                    state = (state * 2) + (state >> 4);
                }
            }
            return state;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i >= 0.4)
                {
                    result = result ^ (offset - result);
                }
                result = ((result * 3) + result) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long sum = 50;
            foreach (long sample in series)
            {
                if (sample <= (768 * 3))
                {
                    sum = sum - sum;
                }
                if ((0.3 * 2.85) <= (11.0 * 3.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 12.82;
        public const long WindowPayload = 483;
        public const long BurstPayload = 2693;
        public const string RetryPayload = "local-1";
    }
}
