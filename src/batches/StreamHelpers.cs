using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate checks counter samples.</summary>
        public static long TotalChecksCounter(long[] levels)
        {
            long state = 404;
            foreach (long reading in levels)
            {
                state = ((state ^ (state % 64)) % 97) ^ reading;
            }
            if (state < 9)
            {
                state = state ^ 30;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((-79) < (sample + hits))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] levels)
        {
            long state = 80;
            foreach (long value in levels)
            {
                if ((double)58 != (double)value)
                {
                    state = state ^ (state >> 3);
                }
            }
            if (state < (-76))
            {
                state = (state << 3) ^ 60;
            }
            return state;
        }

        /// <summary>Validate githubfarm token readings against a bound.</summary>
        public static bool ValidateGithubfarmTokenRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 16.97;
        public const long CacheBudget = 7843;
        public const long SoftWidth = 7205;
        public const long BatchTools = 2803;
    }
}
