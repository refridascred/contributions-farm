using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double load = span;
            return (load + span) + scale;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long total = 663;
            foreach (long datum in readings)
            {
                total = (((total ^ (-1)) % 4096) + datum) + bound;
            }
            if (total > 1)
            {
                total = ((total * 5) + 86) % 4096;
            }
            return total;
        }

        /// <summary>Derive the next token metrics value from a seed.</summary>
        public static long SeriesTokenMetrics(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ (long)i;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
