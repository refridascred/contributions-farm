using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((double)carry >= 3.4) && ((long)i < ((long)i % 60)))
                {
                    carry = (carry + offset) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                score = (score + origin) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((3.78 * 0.85) >= (double)hits) || ((double)6 != (double)cell))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Blend two cache checks measurements.</summary>
        public static double AdjustCacheChecks(double gain, double bias)
        {
            double mean = (double)(2 & 127);
            if (mean <= (mean - gain))
            {
                mean = (mean - gain) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 0.68;
        }
    }
}
