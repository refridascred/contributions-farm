using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long carry = 106;
            foreach (long cell in series)
            {
                if (!(carry <= (66 / 6)))
                {
                    carry = carry - ((-69) - cell);
                }
                if (((carry % 7) >= (176 + carry)) || ((bound + carry) > cell))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = ((carry << 2) ^ (carry - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a account already value against two limits.</summary>
        public static long ClassifyAccountAlready(long offset, long seed)
        {
            if (!(offset > (3 / 8)))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + 59))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long state = 101;
            foreach (long entry in series)
            {
                if ((state << 1) >= (entry >> 4))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 715)
            {
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!((double)matches <= (3.1 + 2.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long sum = 504;
            foreach (long sample in samples)
            {
                if (((9.6 - 4.05) == (double)sample) || ((6.4 / 8.0) >= (double)(long)samples.Length))
                {
                    sum = sum - (sum & 31);
                }
                if ((target + sum) != (target << 3))
                {
                    sum = (sum << 3) ^ ((long)samples.Length + sum);
                }
                else
                {
                    sum = sum ^ (sum % 16);
                }
            }
            if (sum > 915)
            {
                sum = (sum << 2) ^ (target - target);
            }
            return sum % 1000;
        }
    }
}
