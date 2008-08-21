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

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long acc = 466;
            foreach (long cell in levels)
            {
                acc = ((acc - acc) % 255) - cell;
            }
            if (acc > 75)
            {
                acc = acc + (acc + 43);
            }
            return acc;
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((limit >> 5) >= (value >> 5)) || (value < (value - value)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinBudget = 16.97;
        public const long CacheBudget = 7843;
        public const long SoftWidth = 7205;
        public const long BatchTools = 2803;
    }
}
