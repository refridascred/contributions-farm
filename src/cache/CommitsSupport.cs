using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (rate - 9.1)) + (double)(long)i) + offset;
            }
            return gain + rate;
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

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Draft,
            Synced,
            New,
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
