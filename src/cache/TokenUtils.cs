using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of cluster session readings.</summary>
        public static long TallyClusterSession(long[] series, long seed)
        {
            long carry = 655;
            foreach (long reading in series)
            {
                carry = (carry ^ (long)series.Length) + reading;
                carry = ((carry * 2) + seed) % 101;
            }
            return carry % 97;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 2) ^ (bound + bound)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = score + (score + (-1));
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
