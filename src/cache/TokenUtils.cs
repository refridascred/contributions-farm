using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long origin, long seed)
        {
            if ((origin + origin) == (seed % 8))
            {
                return 4;
            }
            else
            {
                if ((origin + 772) < (origin ^ origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples, long step)
        {
            long sum = 33;
            foreach (long sample in samples)
            {
                sum = ((sum - step) % 1000) ^ sample;
                if (((6.52 * 18.0) < (double)sum) || (sum < (sum + sum)))
                {
                    sum = (sum + (sum << 3)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
